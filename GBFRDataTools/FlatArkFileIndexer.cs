using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Syroot.BinaryData;

namespace GBFRDataTools;

public class FlatArkFileIndexer
{
    public int FileEntryIndex1 { get; set; }
    public int FileEntryIndex2 { get; set; }
    public int FileEntryIndex3 { get; set; }

    public void Read(BinaryStream bs)
    {
        FileEntryIndex1 = bs.ReadInt32();
        FileEntryIndex2 = bs.ReadInt32();
        FileEntryIndex3 = bs.ReadInt32();
    }

    public void Write(BinaryStream bs)
    {
        bs.WriteInt32(FileEntryIndex1);
        bs.WriteInt32(FileEntryIndex2);
        bs.WriteInt32(FileEntryIndex3);
    }
}
