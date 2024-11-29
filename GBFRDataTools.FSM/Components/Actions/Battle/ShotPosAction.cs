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

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotPosAction : ActionComponent
{
    [JsonPropertyName("offset_")]
    public /* cVec4 */ Vector4 Offset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; }

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; }

    [JsonPropertyName("scale_")]
    public float Scale { get; set; } = 1.0f;

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = -1;

    [JsonPropertyName("isUpdateAttachParent_")]
    public bool IsUpdateAttachParent { get; set; } = false;

    [JsonPropertyName("isUseOnMoveInfo_")]
    public bool IsUseOnMoveInfo { get; set; } = true;

    [JsonPropertyName("isUseHomingTargetOnMoveInfo_")]
    public bool IsUseHomingTargetOnMoveInfo { get; set; } = true;

    [JsonPropertyName("isInit_")]
    public bool IsInit { get; set; } = true;

    [JsonPropertyName("isAddPosAndRot_")]
    public bool IsAddPosAndRot { get; set; } = false;
}
