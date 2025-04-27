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
    public bool IsCreateAttackSign { get; set; } = false; // Offset 0x508

    [JsonPropertyName("isRotateStorm_")]
    public bool IsRotateStorm { get; set; } = false; // Offset 0x509

    [JsonPropertyName("stormRotateUnitWidth_")]
    public float StormRotateUnitWidth { get; set; } = 1f; // Offset 0x50C

    [JsonPropertyName("stormRotateMaxWidth_")]
    public float StormRotateMaxWidth { get; set; } = 1.5f; // Offset 0x510

    [JsonPropertyName("stormUnitDegSpd_")]
    public float StormUnitDegSpd { get; set; } = 30f; // Offset 0x514

    [JsonPropertyName("stormInitRadius_")]
    public float StormInitRadius { get; set; } = 5f; // Offset 0x518

    [JsonPropertyName("stormUnitExpandRadius_")]
    public float StormUnitExpandRadius { get; set; } = 4f; // Offset 0x51C

    [JsonPropertyName("stormMaxRadius_")]
    public float StormMaxRadius { get; set; } = 10f; // Offset 0x520

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } // Offset 0x528

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x530

    [JsonPropertyName("attackSignTime_")]
    public float AttackSignTime { get; set; } = 1f; // Offset 0x540

    public Em7200JumpStormAction()
    {
    }
}
