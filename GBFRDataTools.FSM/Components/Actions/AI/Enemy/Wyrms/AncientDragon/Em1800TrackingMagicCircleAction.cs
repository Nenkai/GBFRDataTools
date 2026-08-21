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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800TrackingMagicCircleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800TrackingMagicCircleAction);

    [JsonPropertyName("scaleChangeSecond_")]
    public float ScaleChangeSecond { get; set; } = 2f; 

    [JsonPropertyName("warningWaitSecond_")]
    public float WarningWaitSecond { get; set; } = 1f; 

    [JsonPropertyName("warningSecondAILevel1_")]
    public float WarningSecondAILevel1 { get; set; } = 2f; 

    [JsonPropertyName("warningSecondAILevel2_")]
    public float WarningSecondAILevel2 { get; set; } = 2f; 

    [JsonPropertyName("warningSecondAILevel3_")]
    public float WarningSecondAILevel3 { get; set; } = 1f; 

    [JsonPropertyName("warningSecondAILevel4_")]
    public float WarningSecondAILevel4 { get; set; } = 0.5f; 

    [JsonPropertyName("warningSecondAILevel5_")]
    public float WarningSecondAILevel5 { get; set; } = 0.5f; 

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } = 3.6f; 

    [JsonPropertyName("attackSecond_")]
    public float AttackSecond { get; set; } = 0.45f; 

    [JsonPropertyName("paramVector_")]
    public BindingList<Param> ParamVector { get; set; } = []; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Param
    {
        [JsonPropertyName("offset_")]
        public Vector4 Offset { get; set; } 

        [JsonPropertyName("waitSecond_")]
        public float WaitSecond { get; set; } 

        [JsonPropertyName("beginScale_")]
        public float BeginScale { get; set; } 

        [JsonPropertyName("endScale_")]
        public float EndScale { get; set; } 
    }
}
