using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotPosAction : ActionComponent
{
    [JsonPropertyName("offset_")]
    public cVec4 Offset { get; set; }

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; }

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; }

    [JsonPropertyName("scale_")]
    public float Scale { get; set; }

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; }

    [JsonPropertyName("isUpdateAttachParent_")]
    public bool IsUpdateAttachParent { get; set; }

    [JsonPropertyName("isUseOnMoveInfo_")]
    public bool IsUseOnMoveInfo { get; set; }

    [JsonPropertyName("isUseHomingTargetOnMoveInfo_")]
    public bool IsUseHomingTargetOnMoveInfo { get; set; }

    [JsonPropertyName("isInit_")]
    public bool IsInit { get; set; }

    [JsonPropertyName("isAddPosAndRot_")]
    public bool IsAddPosAndRot { get; set; }
}
