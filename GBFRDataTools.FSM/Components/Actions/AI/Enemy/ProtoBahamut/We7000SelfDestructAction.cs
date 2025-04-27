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

public class We7000SelfDestructAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7000SelfDestructAction);

    [JsonPropertyName("isAttackSign_")]
    public bool IsAttackSign { get; set; } = false; // Offset 0x70

    [JsonPropertyName("attackSignRadius_")]
    public float AttackSignRadius { get; set; } = 5f; // Offset 0x90

    public We7000SelfDestructAction()
    {
    }
}