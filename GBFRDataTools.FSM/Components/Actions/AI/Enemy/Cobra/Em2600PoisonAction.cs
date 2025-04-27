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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;

public class Em2600PoisonAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2600PoisonAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; // Offset 0x90

    [JsonPropertyName("diffusionAreaRange_")]
    public float DiffusionAreaRange { get; set; } = 2.5f; // Offset 0x94

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 6; // Offset 0x98

    [JsonPropertyName("disengageRange_")]
    public float DisengageRange { get; set; } = 1f; // Offset 0xA0

    [JsonPropertyName("dirDeg_")]
    public float DirDeg { get; set; } = 90f; // Offset 0xA4

    [JsonPropertyName("targetOffset_")]
    public Vector4 TargetOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0xB0

    public Em2600PoisonAction()
    {
    }
}

