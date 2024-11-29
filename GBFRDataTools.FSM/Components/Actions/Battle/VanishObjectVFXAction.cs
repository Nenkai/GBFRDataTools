
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class VanishObjectVFXAction : ShotHitBaseAction
{
    [JsonPropertyName("blackBoardName_")]
    public string BlackBoardName { get; set; } = string.Empty;

    [JsonPropertyName("vanishTiming_")]
    public int VanishTiming { get; set; } = 0;
}
