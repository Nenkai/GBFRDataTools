using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Game name for it.")]
public enum eObjIdType
{
    pl = 0x10000,
    em = 0x20000,
    wp = 0x30000,
    et = 0x40000,
    ef = 0x50000,
    it = 0x70000,
    sc = 0x90000,
    bg = 0xC0000,
    bh = 0xE0000,
    ba = 0xF0000,
    fp = 0x1000000,
    fe = 0x1010000,
    fn = 0x1020000,
    we = 0x1030000,
    wn = 0x1040000,
    np = 0x10A0000,
    tr = 0x10B0000,
    bt = 0x10C0000,
}

[Flags]
public enum AbilityActionCategoryBit : int
{
    Bit0 = 1 << 0,
    Bit1 = 1 << 1,
    Bit2 = 1 << 2,
    Bit3 = 1 << 3,
    Bit4 = 1 << 4,
    Bit5 = 1 << 5,
    Bit6 = 1 << 6,
    Bit7 = 1 << 7,
    Bit8 = 1 << 8,
    Bit9 = 1 << 9,
    Bit10 = 1 << 10,
    Bit11 = 1 << 11,
    Bit12 = 1 << 12,
    Bit13 = 1 << 13,
    Bit14 = 1 << 14,
    Bit15 = 1 << 15,
    Bit16 = 1 << 16,
    Bit17 = 1 << 17,
    Bit18 = 1 << 18,
    Bit19 = 1 << 19,
    Bit20 = 1 << 20,
    Bit21 = 1 << 21,
    Bit22 = 1 << 22,
    Bit23 = 1 << 23,
    Bit24 = 1 << 24,
    Bit25 = 1 << 25,
    Bit26 = 1 << 26,
    Bit27 = 1 << 27,
    Bit28 = 1 << 28,
    Bit29 = 1 << 29,
    Bit30 = 1 << 30,
    Bit31 = 1 << 31,
}