using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.Entities.Base;
using System.Numerics;
using System.ComponentModel;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.PyetA;

public class Em3100ShotAttackScaleAction : ShotAttackAction
{
    [JsonPropertyName("shotType_")]
    [Description("Valid: 5, 16, 18, 21")]
    public ShotType ShotType { get; set; } = 0;

    [JsonPropertyName("scaleSeconds_")]
    public float ScaleSeconds { get; set; } = 1.0f;

    [JsonPropertyName("scaleSize_")]
    public /* cVec4 */ Vector4 ScaleSize { get; set; } = Vector4.One;

}
