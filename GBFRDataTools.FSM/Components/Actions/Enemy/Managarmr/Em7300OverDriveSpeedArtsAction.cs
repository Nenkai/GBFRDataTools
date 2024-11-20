using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
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
