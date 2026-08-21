using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Radis;

public class Em1805JudgmentThunderAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805JudgmentThunderAction);

    [JsonPropertyName("paramVector_")]
    public BindingList<Param> ParamVector { get; set; } = []; 

    [JsonPropertyName("seedActionWait_")]
    public float SeedActionWait { get; set; } = 0f;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Param
    {
        [JsonPropertyName("offset_")]
        public Vector3 Offset { get; set; } 

        [JsonPropertyName("waitSecond_")]
        public float WaitSecond { get; set; } 

        [JsonPropertyName("waitLatterHalfSecond_")]
        public float WaitLatterHalfSecond { get; set; } 
    }
}

