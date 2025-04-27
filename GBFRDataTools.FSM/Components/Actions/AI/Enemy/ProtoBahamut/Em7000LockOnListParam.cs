using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7000LockOnListParam
{
    [JsonPropertyName("params_")]
    public BindingList<Em7000LockOnParam> Params { get; set; } = []; // Offset 0x8

    public Em7000LockOnListParam()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7000LockOnParam
    {
        [JsonPropertyName("frame_")]
        public int Frame { get; set; } // Offset 0x8

        [JsonPropertyName("partsNo_")]
        public int PartsNo { get; set; } // Offset 0xC

        [JsonPropertyName("isEnable_")]
        public bool IsEnable { get; set; } // Offset 0x10

        public Em7000LockOnParam()
        {
        }
    }
}
