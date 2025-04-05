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

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.PyetA;

public class Em3100ShotAttackScaleAction : ShotAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em3100ShotAttackScaleAction);

    [JsonPropertyName("shotType_")]
    [Description("Valid: 5, 16, 18, 21")]
    public ShotType ShotType { get; set; } = 0;

    [JsonPropertyName("scaleSeconds_")]
    public float ScaleSeconds { get; set; } = 1.0f;

    [JsonPropertyName("scaleSize_")]
    public /* cVec4 */ Vector4 ScaleSize { get; set; } = Vector4.One;

}
