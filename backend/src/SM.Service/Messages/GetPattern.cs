// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GetPattern.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SM.Service.Messages {

  /// <summary>Holder for reflection information generated from GetPattern.proto</summary>
  public static partial class GetPatternReflection {

    #region Descriptor
    /// <summary>File descriptor for GetPattern.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetPatternReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBHZXRQYXR0ZXJuLnByb3RvEgdwYXR0ZXJuIgwKCkdldFBhdHRlcm5CFqoC",
            "E1NNLlNlcnZpY2UuTWVzc2FnZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SM.Service.Messages.GetPattern), global::SM.Service.Messages.GetPattern.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetPattern : pb::IMessage<GetPattern> {
    private static readonly pb::MessageParser<GetPattern> _parser = new pb::MessageParser<GetPattern>(() => new GetPattern());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetPattern> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SM.Service.Messages.GetPatternReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPattern() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPattern(GetPattern other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPattern Clone() {
      return new GetPattern(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetPattern);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetPattern other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetPattern other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
