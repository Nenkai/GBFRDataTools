using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7200MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200MoveToAction);

    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 2f; // Offset 0x74

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; // Offset 0x78

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; // Offset 0x7C

    [JsonPropertyName("skipEndMotion_")]
    public bool SkipEndMotion { get; set; } = true; // Offset 0x80

    [JsonPropertyName("isFirstAction_")]
    public bool IsFirstAction { get; set; } = false; // Offset 0x81

    public Em7200MoveToAction()
    {
    }
}

