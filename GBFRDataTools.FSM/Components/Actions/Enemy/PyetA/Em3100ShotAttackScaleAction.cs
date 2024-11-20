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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.PyetA;

public class Em3100ShotAttackScaleAction : ShotAttackAction
{
    [JsonPropertyName("shotType_")]
    public int ShotType { get; set; }

    [JsonPropertyName("scaleSeconds_")]
    public float ScaleSeconds { get; set; }

    [JsonPropertyName("scaleSize_")]
    public cVec4 ScaleSize { get; set; }

}
