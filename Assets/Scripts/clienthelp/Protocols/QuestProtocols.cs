//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: protobuf/quest.proto
namespace com.kz.message.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"QuestListPro")]
  public partial class QuestListPro : global::ProtoBuf.IExtensible
  {
    public QuestListPro() {}
    
    private readonly global::System.Collections.Generic.List<com.kz.message.proto.QuestPro> _questList = new global::System.Collections.Generic.List<com.kz.message.proto.QuestPro>();
    [global::ProtoBuf.ProtoMember(1, Name=@"questList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.kz.message.proto.QuestPro> questList
    {
      get { return _questList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"QuestPro")]
  public partial class QuestPro : global::ProtoBuf.IExtensible
  {
    public QuestPro() {}
    
    private int _questId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"questId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int questId
    {
      get { return _questId; }
      set { _questId = value; }
    }
    private long _endTime;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"endTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long endTime
    {
      get { return _endTime; }
      set { _endTime = value; }
    }
    private string _data = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string data
    {
      get { return _data; }
      set { _data = value; }
    }
    private int _type;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _state;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int state
    {
      get { return _state; }
      set { _state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}