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

public class We7002IceShotSignAction : ShotAttackSignAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7002IceShotSignAction);

    [JsonPropertyName("lineSignLength_")]
    public float LineSignLength { get; set; } = 32f; // Offset 0xC0

    [JsonPropertyName("iceRotSpeed_")]
    public float IceRotSpeed { get; set; } = 360f; // Offset 0xC4

    public We7002IceShotSignAction()
    {
    }
}