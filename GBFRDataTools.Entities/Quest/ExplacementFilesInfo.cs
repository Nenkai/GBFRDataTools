using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Quest;

public class ExplacementFilesInfo
{
    public List<string> Suffix { get; set; } = [];

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "suffix_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                            Suffix.Add(reader.ReadString());
                    }
                    break;
                default:
                    throw new NotImplementedException($"Property '{key}' not supported for ExplacementFilesInfo");
            }
        }
    }
}
