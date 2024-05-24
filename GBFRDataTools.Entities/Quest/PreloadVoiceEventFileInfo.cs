using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GBFRDataTools.Entities.Quest;

public class PreloadVoiceEventFileInfos
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
                    throw new NotImplementedException($"Property '{key}' not supported for PreloadVoiceEventFileInfos");

            }
        }
    }
}