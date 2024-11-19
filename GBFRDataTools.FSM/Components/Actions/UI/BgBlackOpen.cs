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
    public bool Gauss { get; set; }

    [JsonPropertyName("skipAnim_")]
    public bool SkipAnim { get; set; }

    [JsonPropertyName("bgID_")]
    public string BgID { get; set; }
}
