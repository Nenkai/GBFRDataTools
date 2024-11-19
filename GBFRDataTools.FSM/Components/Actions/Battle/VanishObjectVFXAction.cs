
using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class VanishObjectVFXAction : ShotHitBaseAction
{
    [JsonPropertyName("blackBoardName_")]
    public string BlackBoardName { get; set; }

    [JsonPropertyName("vanishTiming_")]
    public int VanishTiming { get; set; }
}
