using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7200JumpStormAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200JumpStormAction);

    [JsonPropertyName("isCreateAttackSign_")]
    public bool IsCreateAttackSign { get; set; } = false; 

    [JsonPropertyName("isRotateStorm_")]
    public bool IsRotateStorm { get; set; } = false; 

    [JsonPropertyName("stormRotateUnitWidth_")]
    public float StormRotateUnitWidth { get; set; } = 1f; 

    [JsonPropertyName("stormRotateMaxWidth_")]
    public float StormRotateMaxWidth { get; set; } = 1.5f; 

    [JsonPropertyName("stormUnitDegSpd_")]
    public float StormUnitDegSpd { get; set; } = 30f; 

    [JsonPropertyName("stormInitRadius_")]
    public float StormInitRadius { get; set; } = 5f; 

    [JsonPropertyName("stormUnitExpandRadius_")]
    public float StormUnitExpandRadius { get; set; } = 4f; 

    [JsonPropertyName("stormMaxRadius_")]
    public float StormMaxRadius { get; set; } = 10f;

    [JsonPropertyName("motionId_")]
    public string? MotionId { get; set; } = "1700";

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("attackSignTime_")]
    public float AttackSignTime { get; set; } = 1f; 
}
