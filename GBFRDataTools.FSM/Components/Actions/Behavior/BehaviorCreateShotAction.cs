using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

[GameSupport(GameVersion.EndlessRagnarok)]
public class BehaviorCreateShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BehaviorCreateShotAction);

    [JsonPropertyName("fsmClassName_")]
    public string FsmClassName { get; set; }

    [JsonPropertyName("fsmInfix_")]
    public string FsmInfix { get; set; }

    [JsonPropertyName("isUseObjId_")]
    public bool IsUseObjId { get; set; } = false;

    [JsonPropertyName("shotObjId_")]
    public int ShotObjId { get; set; } = -1;

    [JsonPropertyName("isSetPos_")]
    public bool IsSetPos { get; set; } = false;

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = -1;

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isSetRot_")]
    public bool IsSetRot { get; set; } = false;

    [JsonPropertyName("isOwnRot_")]
    public bool IsOwnRot { get; set; } = false;

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; } = 0f;

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; } = 0f;

    [JsonPropertyName("degreeZ_")]
    public float DegreeZ { get; set; } = 0f;

    [JsonPropertyName("isSetScale_")]
    public bool IsSetScale { get; set; } = false;

    [JsonPropertyName("scale_")]
    public float Scale { get; set; } = 1f;

    [JsonPropertyName("isRotateChr_")]
    public bool IsRotateChr { get; set; } = false;

    [JsonPropertyName("isUseBBPos_")]
    public bool IsUseBBPos { get; set; } = false;

    [JsonPropertyName("posBlackBoardValueName_")]
    public string PosBlackBoardValueName { get; set; }

    [JsonPropertyName("isUseBBRot_")]
    public bool IsUseBBRot { get; set; } = false;

    [JsonPropertyName("rotBlackBoardValueName_")]
    public string RotBlackBoardValueName { get; set; }

    [JsonPropertyName("isTrackShot_")]
    public bool IsTrackShot { get; set; } = false;
}