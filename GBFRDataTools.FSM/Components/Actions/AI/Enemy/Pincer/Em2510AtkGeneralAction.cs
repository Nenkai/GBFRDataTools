using GBFRDataTools.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Pincer;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em2510AtkGeneralAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510AtkGeneralAction);

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; } // Offset 0x30

    [JsonPropertyName("animInterTime_")]
    public float AnimInterTime { get; set; } = -1.0f;

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1.0f;

    [JsonPropertyName("isComboAction_")]
    public bool IsComboAction { get; set; } = false;

    [JsonPropertyName("isCounterAction_")]
    public bool IsCounterAction { get; set; } = false;

    [JsonPropertyName("comboMinDist_")]
    public float ComboMinDist { get; set; } = 0f;

    [JsonPropertyName("comboMaxDist_")]
    public float ComboMaxDist { get; set; } = 10000f;
}
