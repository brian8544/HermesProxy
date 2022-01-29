// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bgs/low/pb/client/embed_types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/embed_types.proto</summary>
  public static partial class EmbedTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/embed_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EmbedTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNiZ3MvbG93L3BiL2NsaWVudC9lbWJlZF90eXBlcy5wcm90bxIMYmdzLnBy",
            "b3RvY29sIjgKCkVtYmVkSW1hZ2USCwoDdXJsGAEgASgJEg0KBXdpZHRoGAIg",
            "ASgNEg4KBmhlaWdodBgDIAEoDSIYCghQcm92aWRlchIMCgRuYW1lGAEgASgJ",
            "IjsKCUVtYmVkSFRNTBIPCgdjb250ZW50GAEgASgJEg0KBXdpZHRoGAIgASgN",
            "Eg4KBmhlaWdodBgDIAEoDSLRAQoJRW1iZWRJbmZvEg0KBXRpdGxlGAEgASgJ",
            "EgwKBHR5cGUYAiABKAkSFAoMb3JpZ2luYWxfdXJsGAMgASgJEisKCXRodW1i",
            "bmFpbBgEIAEoCzIYLmJncy5wcm90b2NvbC5FbWJlZEltYWdlEigKCHByb3Zp",
            "ZGVyGAUgASgLMhYuYmdzLnByb3RvY29sLlByb3ZpZGVyEhMKC2Rlc2NyaXB0",
            "aW9uGAYgASgJEiUKBGh0bWwYCCABKAsyFy5iZ3MucHJvdG9jb2wuRW1iZWRI",
            "VE1M"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.EmbedImage), global::Bgs.Protocol.EmbedImage.Parser, new[]{ "Url", "Width", "Height" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Provider), global::Bgs.Protocol.Provider.Parser, new[]{ "Name" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.EmbedHTML), global::Bgs.Protocol.EmbedHTML.Parser, new[]{ "Content", "Width", "Height" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.EmbedInfo), global::Bgs.Protocol.EmbedInfo.Parser, new[]{ "Title", "Type", "OriginalUrl", "Thumbnail", "Provider", "Description", "Html" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EmbedImage : pb::IMessage<EmbedImage> {
    private static readonly pb::MessageParser<EmbedImage> _parser = new pb::MessageParser<EmbedImage>(() => new EmbedImage());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmbedImage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.EmbedTypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbedImage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbedImage(EmbedImage other) : this() {
      _hasBits0 = other._hasBits0;
      url_ = other.url_;
      width_ = other.width_;
      height_ = other.height_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbedImage Clone() {
      return new EmbedImage(this);
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 1;
    private readonly static string UrlDefaultValue = "";

    private string url_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_ ?? UrlDefaultValue; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "url" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasUrl {
      get { return url_ != null; }
    }
    /// <summary>Clears the value of the "url" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearUrl() {
      url_ = null;
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 2;
    private readonly static uint WidthDefaultValue = 0;

    private uint width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Width {
      get { if ((_hasBits0 & 1) != 0) { return width_; } else { return WidthDefaultValue; } }
      set {
        _hasBits0 |= 1;
        width_ = value;
      }
    }
    /// <summary>Gets whether the "width" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasWidth {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "width" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearWidth() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 3;
    private readonly static uint HeightDefaultValue = 0;

    private uint height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Height {
      get { if ((_hasBits0 & 2) != 0) { return height_; } else { return HeightDefaultValue; } }
      set {
        _hasBits0 |= 2;
        height_ = value;
      }
    }
    /// <summary>Gets whether the "height" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasHeight {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "height" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearHeight() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmbedImage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmbedImage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Url != other.Url) return false;
      if (Width != other.Width) return false;
      if (Height != other.Height) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasUrl) hash ^= Url.GetHashCode();
      if (HasWidth) hash ^= Width.GetHashCode();
      if (HasHeight) hash ^= Height.GetHashCode();
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
      if (HasUrl) {
        output.WriteRawTag(10);
        output.WriteString(Url);
      }
      if (HasWidth) {
        output.WriteRawTag(16);
        output.WriteUInt32(Width);
      }
      if (HasHeight) {
        output.WriteRawTag(24);
        output.WriteUInt32(Height);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasUrl) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (HasWidth) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Width);
      }
      if (HasHeight) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Height);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmbedImage other) {
      if (other == null) {
        return;
      }
      if (other.HasUrl) {
        Url = other.Url;
      }
      if (other.HasWidth) {
        Width = other.Width;
      }
      if (other.HasHeight) {
        Height = other.Height;
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
            Url = input.ReadString();
            break;
          }
          case 16: {
            Width = input.ReadUInt32();
            break;
          }
          case 24: {
            Height = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Provider : pb::IMessage<Provider> {
    private static readonly pb::MessageParser<Provider> _parser = new pb::MessageParser<Provider>(() => new Provider());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Provider> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.EmbedTypesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Provider() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Provider(Provider other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Provider Clone() {
      return new Provider(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private readonly static string NameDefaultValue = "";

    private string name_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_ ?? NameDefaultValue; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearName() {
      name_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Provider);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Provider other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasName) hash ^= Name.GetHashCode();
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
      if (HasName) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Provider other) {
      if (other == null) {
        return;
      }
      if (other.HasName) {
        Name = other.Name;
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
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class EmbedHTML : pb::IMessage<EmbedHTML> {
    private static readonly pb::MessageParser<EmbedHTML> _parser = new pb::MessageParser<EmbedHTML>(() => new EmbedHTML());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmbedHTML> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.EmbedTypesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbedHTML() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbedHTML(EmbedHTML other) : this() {
      _hasBits0 = other._hasBits0;
      content_ = other.content_;
      width_ = other.width_;
      height_ = other.height_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbedHTML Clone() {
      return new EmbedHTML(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private readonly static string ContentDefaultValue = "";

    private string content_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_ ?? ContentDefaultValue; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "content" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasContent {
      get { return content_ != null; }
    }
    /// <summary>Clears the value of the "content" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearContent() {
      content_ = null;
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 2;
    private readonly static uint WidthDefaultValue = 0;

    private uint width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Width {
      get { if ((_hasBits0 & 1) != 0) { return width_; } else { return WidthDefaultValue; } }
      set {
        _hasBits0 |= 1;
        width_ = value;
      }
    }
    /// <summary>Gets whether the "width" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasWidth {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "width" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearWidth() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 3;
    private readonly static uint HeightDefaultValue = 0;

    private uint height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Height {
      get { if ((_hasBits0 & 2) != 0) { return height_; } else { return HeightDefaultValue; } }
      set {
        _hasBits0 |= 2;
        height_ = value;
      }
    }
    /// <summary>Gets whether the "height" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasHeight {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "height" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearHeight() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmbedHTML);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmbedHTML other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (Width != other.Width) return false;
      if (Height != other.Height) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasContent) hash ^= Content.GetHashCode();
      if (HasWidth) hash ^= Width.GetHashCode();
      if (HasHeight) hash ^= Height.GetHashCode();
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
      if (HasContent) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (HasWidth) {
        output.WriteRawTag(16);
        output.WriteUInt32(Width);
      }
      if (HasHeight) {
        output.WriteRawTag(24);
        output.WriteUInt32(Height);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasContent) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (HasWidth) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Width);
      }
      if (HasHeight) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Height);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmbedHTML other) {
      if (other == null) {
        return;
      }
      if (other.HasContent) {
        Content = other.Content;
      }
      if (other.HasWidth) {
        Width = other.Width;
      }
      if (other.HasHeight) {
        Height = other.Height;
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
            Content = input.ReadString();
            break;
          }
          case 16: {
            Width = input.ReadUInt32();
            break;
          }
          case 24: {
            Height = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class EmbedInfo : pb::IMessage<EmbedInfo> {
    private static readonly pb::MessageParser<EmbedInfo> _parser = new pb::MessageParser<EmbedInfo>(() => new EmbedInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmbedInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.EmbedTypesReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbedInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbedInfo(EmbedInfo other) : this() {
      title_ = other.title_;
      type_ = other.type_;
      originalUrl_ = other.originalUrl_;
      thumbnail_ = other.HasThumbnail ? other.thumbnail_.Clone() : null;
      provider_ = other.HasProvider ? other.provider_.Clone() : null;
      description_ = other.description_;
      html_ = other.HasHtml ? other.html_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmbedInfo Clone() {
      return new EmbedInfo(this);
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 1;
    private readonly static string TitleDefaultValue = "";

    private string title_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_ ?? TitleDefaultValue; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "title" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasTitle {
      get { return title_ != null; }
    }
    /// <summary>Clears the value of the "title" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTitle() {
      title_ = null;
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private readonly static string TypeDefaultValue = "";

    private string type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_ ?? TypeDefaultValue; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "type" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasType {
      get { return type_ != null; }
    }
    /// <summary>Clears the value of the "type" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearType() {
      type_ = null;
    }

    /// <summary>Field number for the "original_url" field.</summary>
    public const int OriginalUrlFieldNumber = 3;
    private readonly static string OriginalUrlDefaultValue = "";

    private string originalUrl_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OriginalUrl {
      get { return originalUrl_ ?? OriginalUrlDefaultValue; }
      set {
        originalUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "original_url" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasOriginalUrl {
      get { return originalUrl_ != null; }
    }
    /// <summary>Clears the value of the "original_url" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOriginalUrl() {
      originalUrl_ = null;
    }

    /// <summary>Field number for the "thumbnail" field.</summary>
    public const int ThumbnailFieldNumber = 4;
    private global::Bgs.Protocol.EmbedImage thumbnail_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.EmbedImage Thumbnail {
      get { return thumbnail_; }
      set {
        thumbnail_ = value;
      }
    }
    /// <summary>Gets whether the thumbnail field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasThumbnail {
      get { return thumbnail_ != null; }
    }
    /// <summary>Clears the value of the thumbnail field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearThumbnail() {
      thumbnail_ = null;
    }

    /// <summary>Field number for the "provider" field.</summary>
    public const int ProviderFieldNumber = 5;
    private global::Bgs.Protocol.Provider provider_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Provider Provider {
      get { return provider_; }
      set {
        provider_ = value;
      }
    }
    /// <summary>Gets whether the provider field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasProvider {
      get { return provider_ != null; }
    }
    /// <summary>Clears the value of the provider field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearProvider() {
      provider_ = null;
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 6;
    private readonly static string DescriptionDefaultValue = "";

    private string description_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_ ?? DescriptionDefaultValue; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "description" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasDescription {
      get { return description_ != null; }
    }
    /// <summary>Clears the value of the "description" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearDescription() {
      description_ = null;
    }

    /// <summary>Field number for the "html" field.</summary>
    public const int HtmlFieldNumber = 8;
    private global::Bgs.Protocol.EmbedHTML html_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.EmbedHTML Html {
      get { return html_; }
      set {
        html_ = value;
      }
    }
    /// <summary>Gets whether the html field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasHtml {
      get { return html_ != null; }
    }
    /// <summary>Clears the value of the html field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearHtml() {
      html_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmbedInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmbedInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Title != other.Title) return false;
      if (Type != other.Type) return false;
      if (OriginalUrl != other.OriginalUrl) return false;
      if (!object.Equals(Thumbnail, other.Thumbnail)) return false;
      if (!object.Equals(Provider, other.Provider)) return false;
      if (Description != other.Description) return false;
      if (!object.Equals(Html, other.Html)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasTitle) hash ^= Title.GetHashCode();
      if (HasType) hash ^= Type.GetHashCode();
      if (HasOriginalUrl) hash ^= OriginalUrl.GetHashCode();
      if (HasThumbnail) hash ^= Thumbnail.GetHashCode();
      if (HasProvider) hash ^= Provider.GetHashCode();
      if (HasDescription) hash ^= Description.GetHashCode();
      if (HasHtml) hash ^= Html.GetHashCode();
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
      if (HasTitle) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (HasType) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
      if (HasOriginalUrl) {
        output.WriteRawTag(26);
        output.WriteString(OriginalUrl);
      }
      if (HasThumbnail) {
        output.WriteRawTag(34);
        output.WriteMessage(Thumbnail);
      }
      if (HasProvider) {
        output.WriteRawTag(42);
        output.WriteMessage(Provider);
      }
      if (HasDescription) {
        output.WriteRawTag(50);
        output.WriteString(Description);
      }
      if (HasHtml) {
        output.WriteRawTag(66);
        output.WriteMessage(Html);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasTitle) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (HasType) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (HasOriginalUrl) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OriginalUrl);
      }
      if (HasThumbnail) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Thumbnail);
      }
      if (HasProvider) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Provider);
      }
      if (HasDescription) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (HasHtml) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Html);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmbedInfo other) {
      if (other == null) {
        return;
      }
      if (other.HasTitle) {
        Title = other.Title;
      }
      if (other.HasType) {
        Type = other.Type;
      }
      if (other.HasOriginalUrl) {
        OriginalUrl = other.OriginalUrl;
      }
      if (other.HasThumbnail) {
        if (!HasThumbnail) {
          Thumbnail = new global::Bgs.Protocol.EmbedImage();
        }
        Thumbnail.MergeFrom(other.Thumbnail);
      }
      if (other.HasProvider) {
        if (!HasProvider) {
          Provider = new global::Bgs.Protocol.Provider();
        }
        Provider.MergeFrom(other.Provider);
      }
      if (other.HasDescription) {
        Description = other.Description;
      }
      if (other.HasHtml) {
        if (!HasHtml) {
          Html = new global::Bgs.Protocol.EmbedHTML();
        }
        Html.MergeFrom(other.Html);
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
            Title = input.ReadString();
            break;
          }
          case 18: {
            Type = input.ReadString();
            break;
          }
          case 26: {
            OriginalUrl = input.ReadString();
            break;
          }
          case 34: {
            if (!HasThumbnail) {
              Thumbnail = new global::Bgs.Protocol.EmbedImage();
            }
            input.ReadMessage(Thumbnail);
            break;
          }
          case 42: {
            if (!HasProvider) {
              Provider = new global::Bgs.Protocol.Provider();
            }
            input.ReadMessage(Provider);
            break;
          }
          case 50: {
            Description = input.ReadString();
            break;
          }
          case 66: {
            if (!HasHtml) {
              Html = new global::Bgs.Protocol.EmbedHTML();
            }
            input.ReadMessage(Html);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
