using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmLiftupItemizeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmLiftupItemizeAction);

    [JsonPropertyName("motionId_")]
    public string? MotionId { get; set; } 

    [JsonPropertyName("itemizeSeName_")]
    public string? ItemizeSeName { get; set; } 

    [JsonPropertyName("landingSeName_")]
    public string? LandingSeName { get; set; } 

    [JsonPropertyName("itemizeColRadius_")]
    public float ItemizeColRadius { get; set; } = 0.2f; 

    [JsonPropertyName("itemizeColCenterPartsNo_")]
    public int ItemizeColCenterPartsNo { get; set; } = 0; 
}
