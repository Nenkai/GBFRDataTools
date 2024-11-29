using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;
using GBFRDataTools.Entities.Base;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyrms;

public class Em1802EasingScaleAction : ShotAttackAction
{
    [JsonPropertyName("scaleSeconds_")]
    public float ScaleSeconds { get; set; } = 1.0f;

    [JsonPropertyName("scaleSize_")]
    public /* cVec4 */ Vector4 ScaleSize { get; set; } = Vector4.One;

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();
}
