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
    public float ScaleChangeSecond { get; set; } = 2f; // Offset 0x58

    [JsonPropertyName("warningWaitSecond_")]
    public float WarningWaitSecond { get; set; } = 1f; // Offset 0x5C

    [JsonPropertyName("warningSecondAILevel1_")]
    public float WarningSecondAILevel1 { get; set; } = 2f; // Offset 0x60

    [JsonPropertyName("warningSecondAILevel2_")]
    public float WarningSecondAILevel2 { get; set; } = 2f; // Offset 0x64

    [JsonPropertyName("warningSecondAILevel3_")]
    public float WarningSecondAILevel3 { get; set; } = 1f; // Offset 0x68

    [JsonPropertyName("warningSecondAILevel4_")]
    public float WarningSecondAILevel4 { get; set; } = 0.5f; // Offset 0x6C

    [JsonPropertyName("warningSecondAILevel5_")]
    public float WarningSecondAILevel5 { get; set; } = 0.5f; // Offset 0x70

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } = 3.6f; // Offset 0x74

    [JsonPropertyName("attackSecond_")]
    public float AttackSecond { get; set; } = 0.45f; // Offset 0x78

    [JsonPropertyName("paramVector_")]
    public BindingList<Param> ParamVector { get; set; } = []; // Offset 0x80

    public Em1800TrackingMagicCircleAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Param
    {
        [JsonPropertyName("offset_")]
        public Vector4 Offset { get; set; } // Offset 0x10

        [JsonPropertyName("waitSecond_")]
        public float WaitSecond { get; set; } // Offset 0x20

        [JsonPropertyName("beginScale_")]
        public float BeginScale { get; set; } // Offset 0x24

        [JsonPropertyName("endScale_")]
        public float EndScale { get; set; } // Offset 0x28
    }
}
