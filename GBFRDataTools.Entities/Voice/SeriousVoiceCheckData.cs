using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Voice;

public class SeriousVoiceCheckData
{
    [JsonPropertyName("tables_")]
    public BindingList<TableData> Tables { get; set; } = []; // Offset 0x8

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class TableData
    {
        [JsonPropertyName("to_")]
        public string To { get; set; } // Offset 0x8

        [JsonPropertyName("from_")]
        public string From { get; set; } // Offset 0x28

        [JsonPropertyName("type_")]
        public string Type { get; set; } // Offset 0x48
    }
}


