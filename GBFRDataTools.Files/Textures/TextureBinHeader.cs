using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.Textures;

// Reverse-Engineered with debug symbols (Vanquish, PS3)
public struct TextureBinHeader
{
    public const uint MAGIC = 0x425457; // "WTB\0"

    public uint m_Magic; // u8 m_pMagic[4]
    public uint m_Version;
    public uint m_nTex;
    public uint m_OfsOfs;
    public uint m_SizeOfs;
    public uint m_FlgOfs;
    public uint m_HashOfs;
    public uint m_ImageHead;
}
