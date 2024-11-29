using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class BgBlackOpen : ActionComponent
{
    [JsonPropertyName("gauss_")]
    public bool Gauss { get; set; } = false;

    [JsonPropertyName("skipAnim_")]
    public bool SkipAnim { get; set; } = false;

    [JsonPropertyName("bgID_")]
    public string BgID { get; set; } = "BgBlack";
}
