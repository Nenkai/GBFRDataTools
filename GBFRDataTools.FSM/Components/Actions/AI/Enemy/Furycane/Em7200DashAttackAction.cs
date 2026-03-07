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
    public float MoveSpd { get; set; } = 10f; // Offset 0x51C

    [JsonPropertyName("moveDist_")]
    public float MoveDist { get; set; } = 12f; // Offset 0x520

    [JsonPropertyName("forceEndTime_")]
    public float ForceEndTime { get; set; } = 5f; // Offset 0x524

    [JsonPropertyName("checkDist_")]
    public float CheckDist { get; set; } = 6f; // Offset 0x528

    [JsonPropertyName("checkAngle_")]
    public float CheckAngle { get; set; } = 45f; // Offset 0x52C

    [JsonPropertyName("startMotionId_")]
    public string StartMotionId { get; set; } // Offset 0x530

    [JsonPropertyName("loopMotionId_")]
    public string LoopMotionId { get; set; } // Offset 0x538

    [JsonPropertyName("endMotionId_")]
    public string EndMotionId { get; set; } // Offset 0x540

    [JsonPropertyName("turnEndMotionId_")]
    public string TurnEndMotionId { get; set; } // Offset 0x548

    public Em7200DashAttackAction()
    {
    }
}
