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
    public string MotionId { get; set; } // Offset 0x60

    [JsonPropertyName("itemizeSeName_")]
    public string ItemizeSeName { get; set; } // Offset 0x80

    [JsonPropertyName("landingSeName_")]
    public string LandingSeName { get; set; } // Offset 0xD0

    [JsonPropertyName("itemizeColRadius_")]
    public float ItemizeColRadius { get; set; } = 0.2f; // Offset 0x120

    [JsonPropertyName("itemizeColCenterPartsNo_")]
    public int ItemizeColCenterPartsNo { get; set; } = 0; // Offset 0x124

    public EmLiftupItemizeAction()
    {
    }
}
