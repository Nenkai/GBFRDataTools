using System;
using System.Collections.Generic;
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
