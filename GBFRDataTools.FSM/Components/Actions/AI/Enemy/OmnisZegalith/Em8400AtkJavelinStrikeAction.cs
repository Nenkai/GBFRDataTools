using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400AtkJavelinStrikeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkJavelinStrikeAction);

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 10;

    [JsonPropertyName("actionEndIntervalFrame_")]
    public int ActionEndIntervalFrame { get; set; } = 90;

    [JsonPropertyName("shotRapidFrame_")]
    public int ShotRapidFrame { get; set; } = 20;

    [JsonPropertyName("homingFrame_")]
    public int HomingFrame { get; set; } = 60;

    [JsonPropertyName("attackDelayFrame_")]
    public int AttackDelayFrame { get; set; } = 90;

    [JsonPropertyName("cameraClearDelayFrame_")]
    public int CameraClearDelayFrame { get; set; } = 480;

    [JsonPropertyName("circleSetDistance_")]
    public float CircleSetDistance { get; set; } = 20f;

    [JsonPropertyName("shotPosHeight_")]
    public float ShotPosHeight { get; set; } = 8f;

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = "shot_javelin_strike";
}