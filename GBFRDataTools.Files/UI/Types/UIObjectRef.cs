using GBFRDataTools.Hashing;

using Syroot.BinaryData;

using YamlDotNet.Serialization;

namespace GBFRDataTools.Files.UI.Types;

public class UIObjectRef
{
    public CyanStringHash ComponentName { get; set; }
    public short Index { get; set; }
    public short ObjectRefId { get; set; }

    public UIObjectRef() { }

    public UIObjectRef(string componentName, short index, short objectRefId)
    {
        ComponentName = new CyanStringHash(componentName);
        Index = index;
        ObjectRefId = objectRefId;
    }

    public UIObjectRef(uint componentNameHash, short index, short objectRefId)
    {
        ComponentName = new CyanStringHash(componentNameHash);
        Index = index;
        ObjectRefId = objectRefId;
    }

    public void Write(BinaryStream bs)
    {
        ComponentName ??= new CyanStringHash();

        ComponentName.Write(bs);
        bs.WriteInt16(Index);
        bs.WriteInt16(ObjectRefId);
    }
}
