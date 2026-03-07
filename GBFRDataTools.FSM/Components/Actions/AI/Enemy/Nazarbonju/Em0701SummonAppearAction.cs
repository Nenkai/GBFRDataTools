using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0701SummonAppearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0701SummonAppearAction);

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; } // Offset 0xA8

    [JsonPropertyName("summonStartSeDefineName_")]
    public string SummonStartSeDefineName { get; set; } // Offset 0x100

    [JsonPropertyName("isHoming_")]
    public bool IsHoming { get; set; } = false; // Offset 0xB0

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 1f; // Offset 0xB4

    [JsonPropertyName("moveToOffset_")]
    public Vector4 MoveToOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0xC0

    [JsonPropertyName("moveStartSec_")]
    public float MoveStartSec { get; set; } = 0f; // Offset 0xB8

    [JsonPropertyName("isAloneSummon_")]
    public bool IsAloneSummon { get; set; } = false; // Offset 0xF0

    [JsonPropertyName("summonWaitSec_")]
    public float SummonWaitSec { get; set; } = 1f; // Offset 0xF4

    [JsonPropertyName("summonAppearDelaySec_")]
    public float SummonAppearDelaySec { get; set; } = 0f; // Offset 0xF8

    [JsonPropertyName("isEnableLockOn_")]
    public bool IsEnableLockOn { get; set; } = true; // Offset 0xB1

    [JsonPropertyName("isEnableDamage_")]
    public bool IsEnableDamage { get; set; } = true; // Offset 0xB2

    [JsonPropertyName("forceCharge_")]
    public bool ForceCharge { get; set; } = false; // Offset 0xB3

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } // Offset 0xD0

    public Em0701SummonAppearAction()
    {
    }
}
