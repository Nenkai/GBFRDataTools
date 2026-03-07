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

public class Em7201ReadyExContinuousWhirlWindAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201ReadyExContinuousWhirlWindAction);

    [JsonPropertyName("destPos_")]
    public Vector4 DestPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x40

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } // Offset 0x50

    public Em7201ReadyExContinuousWhirlWindAction()
    {
    }
}





