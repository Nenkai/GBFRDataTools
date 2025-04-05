using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Furycane;

public class Em7201ExtendsShotAttackAction : ShotAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201ExtendsShotAttackAction);

    [JsonPropertyName("dependMove_")]
    public bool DependMove { get; set; } = false;

    [JsonPropertyName("scaleSeconds_")]
    public float ScaleSeconds { get; set; } = 1.0f;

    [JsonPropertyName("scaleSize_")]
    public /* cVec4 */ Vector4 ScaleSize { get; set; } = Vector4.UnitW;

}
