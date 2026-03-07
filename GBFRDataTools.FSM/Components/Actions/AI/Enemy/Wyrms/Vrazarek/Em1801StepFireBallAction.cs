using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Vrazarek;

public class Em1801RapidFireBallAction : Em1800RapidFireBallAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801RapidFireBallAction);

    [JsonPropertyName("secondBlendMotionRateSpeed_")]
    public float SecondBlendMotionRateSpeed { get; set; } = 0.007f; // Offset 0x64

    [JsonPropertyName("minOffsetDist_")]
    public float MinOffsetDist { get; set; } = 5f; // Offset 0x54

    [JsonPropertyName("maxOffsetDist_")]
    public float MaxOffsetDist { get; set; } = 20f; // Offset 0x58

    [JsonPropertyName("offsetRate_")]
    public float OffsetRate { get; set; } = 1.5f; // Offset 0x5C

    [JsonPropertyName("maxOffsetRot_")]
    public float MaxOffsetRot { get; set; } = 60f; // Offset 0x60

    public Em1801RapidFireBallAction()
    {
    }
}
