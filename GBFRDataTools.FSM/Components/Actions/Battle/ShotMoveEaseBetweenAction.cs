using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ShotMoveEaseBetweenAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotMoveEaseBetweenAction);

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 1f;

    [JsonPropertyName("isMoveSpeedMode_")]
    public bool IsMoveSpeedMode { get; set; } = false;

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 1f;
}

