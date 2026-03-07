using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Quest;

public class ShortStory
{
    public bool IsPhaseMoveDelete { get; set; }

    public void Read(ref MessagePackReader reader)
    {
        int mapCount = reader.ReadMapHeader();
        for (int i = 0; i < mapCount; i++)
        {
            string key = reader.ReadString();
            IsPhaseMoveDelete = key switch
            {
                "isPhaseMoveDelete_" => bool.Parse(reader.ReadString()),
                _ => throw new NotImplementedException($"Property '{key}' not supported for ShortStory"),
            };
        }
    }
}
