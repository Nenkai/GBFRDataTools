using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GBFRDataTools.Entities.Quest;

public class PreloadQuestFSMFileInfo
{
    public FileInfo Info { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "info_":
                    Info = new FileInfo();
                    Info.Read(ref reader);
                    break;

                default:
                    throw new NotImplementedException($"Property '{key}' not supported for PreloadQuestFSMFileInfo");
            }
        }
    }
}

public class FileInfo
{
    public int Index { get; set; }
    public List<string> Names { get; set; } = [];

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "index_":
                    Index = int.Parse(reader.ReadString());
                    break;

                case "names_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            Names.Add(reader.ReadString());
                        }
                    }
                    break;
                default:
                    throw new NotImplementedException($"Property '{key}' not supported for FileInfo");

            }
        }
    }
}
