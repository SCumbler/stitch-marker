﻿using System;
using System.Threading.Tasks;
using EventStore.ClientAPI;
using Proto;
using SM.Service.Extensions;
using SM.Service.Infrastructure.EventStore;
using SM.Service.Messages;

namespace SM.Service.Patterns
{
    public class EventSubscriptionActor : IActor
    {
        private readonly ISubscriptionEventStoreConnection connection;
        private IContext cts;
        private Position? position = Position.Start;

        public EventSubscriptionActor(ISubscriptionEventStoreConnection connection) => this.connection = connection;

        public async Task ReceiveAsync(IContext context)
        {
            switch (context.Message)
            {
                case Started _:
                    cts = context;
                    Subscribe();
                    break;
            }
        }

        private void Subscribe() =>
            connection.SubscribeToAllFrom(
                position,
                new CatchUpSubscriptionSettings(100, 100, false, false),
                EventAppeared,
                LiveProcessingStarted,
                SubscriptionDropped);

        private void LiveProcessingStarted(EventStoreCatchUpSubscription subscription) =>
            cts.Parent.Tell(new LiveProcessingStarted());

        private void SubscriptionDropped(
            EventStoreCatchUpSubscription eventStoreCatchUpSubscription,
            SubscriptionDropReason subscriptionDropReason,
            Exception exception) => Subscribe();

        private async Task EventAppeared(EventStoreCatchUpSubscription eventStoreCatchUpSubscription, ResolvedEvent resolvedEvent)
        {
            if (!resolvedEvent.OriginalStreamId.StartsWith("$"))
                cts.Parent.Tell(resolvedEvent.Event.ReadMessage());
            position = resolvedEvent.OriginalPosition;
        }
    }
}
