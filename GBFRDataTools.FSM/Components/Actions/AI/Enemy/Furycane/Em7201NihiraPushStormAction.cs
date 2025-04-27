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

public class Em7201NihiraPushStormAction : Em7200ComboBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201NihiraPushStormAction);

    [JsonPropertyName("startWait_")]
    public float StartWait { get; set; } = 1.5f; // Offset 0x528

    [JsonPropertyName("marshWaitMin_")]
    public float MarshWaitMin { get; set; } = 0.1f; // Offset 0x52C

    [JsonPropertyName("marshWaitMax_")]
    public float MarshWaitMax { get; set; } = 0.2f; // Offset 0x530

    [JsonPropertyName("rayOffset_")]
    public Vector4 RayOffset { get; set; } = new Vector4(0f, 0.5f, 0f, 1f); // Offset 0x540

    [JsonPropertyName("pushPower_")]
    public float PushPower { get; set; } = 4f; // Offset 0x550

    [JsonPropertyName("startMotionId_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public string StartMotionId { get; set; } // Offset 0x550

    public Em7201NihiraPushStormAction()
    {
    }
}





