using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkMagicCombo1_2_3Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkMagicCombo1_2_3Action);

    [JsonPropertyName("isTypeB_")]
    public bool IsTypeB { get; set; } = false; 

    [JsonPropertyName("targetDistanceMin_")]
    public float TargetDistanceMin { get; set; } = 5f; 

    [JsonPropertyName("targetDistanceMax_")]
    public float TargetDistanceMax { get; set; } = 20f; 
}