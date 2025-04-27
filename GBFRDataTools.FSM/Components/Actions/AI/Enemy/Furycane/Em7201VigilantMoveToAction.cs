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

public class Em7201VigilantMoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201VigilantMoveToAction);

    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 2f; // Offset 0xB4

    [JsonPropertyName("interTime_")]
    public float InterTime { get; set; } = 0.3f; // Offset 0xB8

    [JsonPropertyName("moveSpdNormal_")]
    public float MoveSpdNormal { get; set; } = 20f; // Offset 0xBC

    [JsonPropertyName("moveSpdBroken_")]
    public float MoveSpdBroken { get; set; } = 8f; // Offset 0xC0

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 2f; // Offset 0xC4

    [JsonPropertyName("axelRate_")]
    public float AxelRate { get; set; } = 10f; // Offset 0xC8

    public Em7201VigilantMoveToAction()
    {
    }
}





