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

public class Em7200ReadyContinuousWhirlWindAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200ReadyContinuousWhirlWindAction);

    [JsonPropertyName("destPos_")]
    public Vector4 DestPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("motionId_")]
    public string? MotionId { get; set; } = "1a10";
}



