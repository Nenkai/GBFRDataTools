using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class We7002IceShotHomingAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7002IceShotHomingAction);

    [JsonPropertyName("homingRotSpeed_")]
    public float HomingRotSpeed { get; set; } = 360f; // Offset 0x80

    [JsonPropertyName("iceRotSpeed_")]
    public float IceRotSpeed { get; set; } = 360f; // Offset 0x84

    [JsonPropertyName("homingSec_")]
    public float HomingSec { get; set; } = 1f; // Offset 0x88

    public We7002IceShotHomingAction()
    {
    }
}