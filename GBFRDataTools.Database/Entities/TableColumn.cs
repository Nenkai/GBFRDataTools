using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Database.Entities;

public class TableColumn
{
    public string Name { get; set; }
    public DBColumnType Type { get; set; }
    public long Offset { get; set; }
    public int StringLength { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Type} at {Offset:X8})";
    }
}

public enum DBColumnType
{
    Unknown,
    Byte,
    Short,
    Int,
    UInt,
    HexUInt,
    Float,
    Int64,
    Double,
    String,
    RawString,
    HashString,
    StringPointer,
}
