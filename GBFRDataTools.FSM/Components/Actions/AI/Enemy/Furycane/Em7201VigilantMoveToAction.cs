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
    public float MinWaitTime { get; set; } = 2f; 

    [JsonPropertyName("interTime_")]
    public float InterTime { get; set; } = 0.3f; 

    [JsonPropertyName("moveSpdNormal_")]
    public float MoveSpdNormal { get; set; } = 20f; 

    [JsonPropertyName("moveSpdBroken_")]
    public float MoveSpdBroken { get; set; } = 8f; 

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 2f; 

    [JsonPropertyName("axelRate_")]
    public float AxelRate { get; set; } = 10f; 
}





