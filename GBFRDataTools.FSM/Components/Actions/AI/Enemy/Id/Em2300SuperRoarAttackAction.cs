using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Id;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em2300SuperRoarAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2300SuperRoarAttackAction);

    [JsonPropertyName("isDoubleRotate_")]
    public bool IsDoubleRotate { get; set; } = true;

    [JsonPropertyName("roarRotateMotionSpeed_")]
    public float RoarRotateMotionSpeed { get; set; } = 1f;
}
