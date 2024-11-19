using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7300OverDriveSpeedArtsAction : ActionComponent
{
    [JsonPropertyName("setInterval_")]
    public cVec4 SetInterval { get; set; }

    [JsonPropertyName("slashInterval_")]
    public cVec4 SlashInterval { get; set; }

    [JsonPropertyName("slashEndTime_")]
    public float SlashEndTime { get; set; }

    [JsonPropertyName("isDoppel_")]
    public bool IsDoppel { get; set; }
}
