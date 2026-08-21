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

public class Em7200DashAttackAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200DashAttackAction);

    [JsonPropertyName("moveSpd_")]
    public float MoveSpd { get; set; } = 10f; 

    [JsonPropertyName("moveDist_")]
    public float MoveDist { get; set; } = 12f; 

    [JsonPropertyName("forceEndTime_")]
    public float ForceEndTime { get; set; } = 5f; 

    [JsonPropertyName("checkDist_")]
    public float CheckDist { get; set; } = 6f; 

    [JsonPropertyName("checkAngle_")]
    public float CheckAngle { get; set; } = 45f;

    [JsonPropertyName("startMotionId_")]
    public string? StartMotionId { get; set; } = "1130";

    [JsonPropertyName("loopMotionId_")]
    public string? LoopMotionId { get; set; } = "1131";

    [JsonPropertyName("endMotionId_")]
    public string? EndMotionId { get; set; } = "1132";

    [JsonPropertyName("turnEndMotionId_")]
    public string? TurnEndMotionId { get; set; } = "1133";
}
