using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.ProtoBahamut;

public class Em7001SetCameraRollAction : ActionComponent
{
    [JsonPropertyName("rollDegree_")]
    public float RollDegree { get; set; }

    [JsonPropertyName("offsetRollDegree_")]
    public float OffsetRollDegree { get; set; }

    [JsonPropertyName("rollSec_")]
    public float RollSec { get; set; }

    [JsonPropertyName("resetRollSec_")]
    public float ResetRollSec { get; set; }

    [JsonPropertyName("isLocalRoll_")]
    public bool IsLocalRoll { get; set; }

    [JsonPropertyName("rollAxis_")]
    public cVec4 RollAxis { get; set; }
}
