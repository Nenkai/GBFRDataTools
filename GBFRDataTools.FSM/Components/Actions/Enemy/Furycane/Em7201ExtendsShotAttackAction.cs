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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Furycane;

public class Em7201ExtendsShotAttackAction : ShotAttackAction
{
    [JsonPropertyName("dependMove_")]
    public bool DependMove { get; set; }

    [JsonPropertyName("scaleSeconds_")]
    public float ScaleSeconds { get; set; }

    [JsonPropertyName("scaleSize_")]
    public cVec4 ScaleSize { get; set; }

}
