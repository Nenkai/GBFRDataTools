using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class PauseGame : ActionComponent
{
    [JsonPropertyName("pause_")]
    public bool Pause { get; set; }

    [JsonPropertyName("offFr_")]
    public int OffFr { get; set; }
}
