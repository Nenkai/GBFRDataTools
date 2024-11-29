using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Sound;

public class CommonFsmSeCallAction : ActionComponent
{
    [JsonPropertyName("seName_")]
    public string SeName { get; set; } = string.Empty;

    [JsonPropertyName("isWorldPositionSet_")]
    public bool IsWorldPositionSet { get; set; } = false;

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = -1;
}
