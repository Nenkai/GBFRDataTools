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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Furycane;

public class Em7201ExtendsShotAttackAction : ShotAttackAction
{
    [JsonPropertyName("dependMove_")]
    public bool DependMove { get; set; } = false;

    [JsonPropertyName("scaleSeconds_")]
    public float ScaleSeconds { get; set; } = 1.0f;

    [JsonPropertyName("scaleSize_")]
    public /* cVec4 */ Vector4 ScaleSize { get; set; } = Vector4.UnitW;

}
