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
public class Em8400AtkRingShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkRingShotAction);

    [JsonPropertyName("actionEndIntervalFrame_")]
    public int ActionEndIntervalFrame { get; set; } = 90;

    [JsonPropertyName("shotStartDelayFrame_")]
    public int ShotStartDelayFrame { get; set; } = 0;

    [JsonPropertyName("shotRapidFrame_")]
    public int ShotRapidFrame { get; set; } = 20;

    [JsonPropertyName("startDir_")]
    public float StartDir { get; set; } = 1f;

    [JsonPropertyName("endDir_")]
    public float EndDir { get; set; } = 15f;

    [JsonPropertyName("scaleTimeSec_")]
    public float ScaleTimeSec { get; set; } = 3f;

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } = 0.2f;

    [JsonPropertyName("shotPosOffsetList_")]
    public BindingList<ShotPosParam> ShotPosOffsetList { get; set; } = []; // std::vector<BT::Em8400AtkRingShotAction::ShotPosParam>

    [JsonPropertyName("moveDistance_")]
    public float MoveDistance { get; set; } = 0f;

    [JsonPropertyName("moveTimeSec_")]
    public float MoveTimeSec { get; set; } = 1.5f;

    [JsonPropertyName("basePosOffset_")]
    public Vector4 BasePosOffset { get; set; } = new Vector4(0f, 4f, 0f, 1f);

    [JsonPropertyName("isShowSkillName_")]
    public bool IsShowSkillName { get; set; } = false;

    [JsonPropertyName("moveEaseParam_")]
    public EaseParam MoveEaseParam { get; set; } = new();

    public class ShotPosParam /* Em8400AtkRingShotAction::ShotPosParam */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    
        [JsonPropertyName("rotY_")]
        public float RotY { get; set; }
    }
}