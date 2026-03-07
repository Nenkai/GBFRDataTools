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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300DiamondDustAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300DiamondDustAction);

    [JsonPropertyName("attackCount_")]
    public int AttackCount { get; set; } = 5; // Offset 0x44

    [JsonPropertyName("attackInterval_")]
    public float AttackInterval { get; set; } = 1f; // Offset 0x48

    [JsonPropertyName("isOdArts_")]
    public bool IsOdArts { get; set; } = false; // Offset 0x4C

    [JsonPropertyName("isCrack_")]
    public bool IsCrack { get; set; } = false; // Offset 0x4D

    public Em7300DiamondDustAction()
    {
    }
}

