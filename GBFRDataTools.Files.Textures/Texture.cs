using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.Textures;

public class Texture
{
    private byte[] _dxBaseTex { get; set; }
    public TEXTURE_FLAG Flag { get; set; }
    public uint Hash { get; set; }

    public byte[] GetData()
    {
        return _dxBaseTex;
    }

    public void SetData(byte[] dds)
    {
        _dxBaseTex = dds;
    }
}

[Flags]
public enum TEXTURE_FLAG : uint
{
    TEXTURE_FLAG_CUBE = 0x80000000,
    TEXTURE_FLAG_360 = 0x40000000,
    TEXTURE_FLAG_ALPHA = 0x20000000,
    TEXTURE_FLAG_PUNCH = 0x10000000,
    TEXTURE_FLAG_UNK_0x20 = 0x20,
    TEXTURE_FLAG_MIP_NO_USE = 0x2,
    TEXTURE_FLAG_DUMMY = 0x1,
}
