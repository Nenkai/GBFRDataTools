using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300DamageMotionPlayAction : EmDamageMotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300DamageMotionPlayAction);

    [JsonPropertyName("animIdPower_")]
    public string AnimIdPower { get; set; } = "b000";

    public Em7300DamageMotionPlayAction()
    {
        InterTime = -1f;
        AnimMoveRateXZ = 1f;
        AnimMoveRateY = 1f;
        AnimSpeedRate = 0f;
        AnimSpeedStep = 0;
        GravityRate = 0f;
        GravityRateStep = 0;
    }
}
