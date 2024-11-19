using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotDamageAction : ShotHitBaseAction
{
    [JsonPropertyName("layer_")]
    public int Layer { get; set; }

    [JsonPropertyName("hp_")]
    public int Hp { get; set; }

    [JsonPropertyName("damageDisp_")]
    public bool DamageDisp { get; set; }
}
