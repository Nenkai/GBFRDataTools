using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Player;

public class PlayerNeckTargetAction : ActionComponent
{
    [JsonPropertyName("target_")]
    public cVec4 Target { get; set; }
}
