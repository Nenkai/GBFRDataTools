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
    public BindingList<Em7000LockOnParam> Params { get; set; } = []; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7000LockOnParam
    {
        [JsonPropertyName("frame_")]
        public int Frame { get; set; } 

        [JsonPropertyName("partsNo_")]
        public int PartsNo { get; set; } 

        [JsonPropertyName("isEnable_")]
        public bool IsEnable { get; set; } 
    }
}
