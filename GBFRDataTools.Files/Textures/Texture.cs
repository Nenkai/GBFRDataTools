using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.Textures;

public class Texture
{
    private byte[] _dxBaseTex { get; set; }
    public uint Flag { get; set; }
    public uint Hash { get; set; }

    public byte[] GetDDS()
    {
        return _dxBaseTex;
    }

    public void SetDDS(byte[] dds)
    {
        _dxBaseTex = dds;
    }
}
