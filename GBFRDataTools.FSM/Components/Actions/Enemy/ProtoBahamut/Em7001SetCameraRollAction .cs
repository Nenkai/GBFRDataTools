using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.ProtoBahamut;

public class Em7001SetCameraRollAction : ActionComponent
{
    [JsonPropertyName("rollDegree_")]
    public float RollDegree { get; set; } = 0.0f;

    [JsonPropertyName("offsetRollDegree_")]
    public float OffsetRollDegree { get; set; } = 0.5f;

    [JsonPropertyName("rollSec_")]
    public float RollSec { get; set; } = 0.0f;

    [JsonPropertyName("resetRollSec_")]
    public float ResetRollSec { get; set; } = 1.0f;

    [JsonPropertyName("isLocalRoll_")]
    public bool IsLocalRoll { get; set; } = true;

    [JsonPropertyName("rollAxis_")]
    public /* cVec4 */ Vector4 RollAxis { get; set; } = Vector4.UnitW;
}
