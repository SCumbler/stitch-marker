// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PatternCreated.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SM.Service {

  /// <summary>Holder for reflection information generated from PatternCreated.proto</summary>
  public static partial class PatternCreatedReflection {

    #region Descriptor
    /// <summary>File descriptor for PatternCreated.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PatternCreatedReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQYXR0ZXJuQ3JlYXRlZC5wcm90bxIHcGF0dGVybhoNUGF0dGVybi5wcm90",
            "byJYCg5QYXR0ZXJuQ3JlYXRlZBIRCglzb3VyY2VfaWQYASABKAkSIQoHcGF0",
            "dGVybhgCIAEoCzIQLnBhdHRlcm4uUGF0dGVybhIQCghvd25lcl9pZBgDIAEo",
            "CUINqgIKU00uU2VydmljZVAAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::SM.Service.PatternReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SM.Service.PatternCreated), global::SM.Service.PatternCreated.Parser, new[]{ "SourceId", "Pattern", "OwnerId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PatternCreated : pb::IMessage<PatternCreated> {
    private static readonly pb::MessageParser<PatternCreated> _parser = new pb::MessageParser<PatternCreated>(() => new PatternCreated());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PatternCreated> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SM.Service.PatternCreatedReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PatternCreated() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PatternCreated(PatternCreated other) : this() {
      sourceId_ = other.sourceId_;
      Pattern = other.pattern_ != null ? other.Pattern.Clone() : null;
      ownerId_ = other.ownerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PatternCreated Clone() {
      return new PatternCreated(this);
    }

    /// <summary>Field number for the "source_id" field.</summary>
    public const int SourceIdFieldNumber = 1;
    private string sourceId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceId {
      get { return sourceId_; }
      set {
        sourceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pattern" field.</summary>
    public const int PatternFieldNumber = 2;
    private global::SM.Service.Pattern pattern_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::SM.Service.Pattern Pattern {
      get { return pattern_; }
      set {
        pattern_ = value;
      }
    }

    /// <summary>Field number for the "owner_id" field.</summary>
    public const int OwnerIdFieldNumber = 3;
    private string ownerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OwnerId {
      get { return ownerId_; }
      set {
        ownerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PatternCreated);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PatternCreated other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceId != other.SourceId) return false;
      if (!object.Equals(Pattern, other.Pattern)) return false;
      if (OwnerId != other.OwnerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceId.Length != 0) hash ^= SourceId.GetHashCode();
      if (pattern_ != null) hash ^= Pattern.GetHashCode();
      if (OwnerId.Length != 0) hash ^= OwnerId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SourceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SourceId);
      }
      if (pattern_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pattern);
      }
      if (OwnerId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(OwnerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SourceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceId);
      }
      if (pattern_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pattern);
      }
      if (OwnerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OwnerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PatternCreated other) {
      if (other == null) {
        return;
      }
      if (other.SourceId.Length != 0) {
        SourceId = other.SourceId;
      }
      if (other.pattern_ != null) {
        if (pattern_ == null) {
          pattern_ = new global::SM.Service.Pattern();
        }
        Pattern.MergeFrom(other.Pattern);
      }
      if (other.OwnerId.Length != 0) {
        OwnerId = other.OwnerId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SourceId = input.ReadString();
            break;
          }
          case 18: {
            if (pattern_ == null) {
              pattern_ = new global::SM.Service.Pattern();
            }
            input.ReadMessage(pattern_);
            break;
          }
          case 26: {
            OwnerId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
