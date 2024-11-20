using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmDamageMotionPlayDirAction : ActionComponent
{
    [JsonPropertyName("enabledFrontDegree_")]
    public float EnabledFrontDegree { get; set; }

    [JsonPropertyName("enabledBackDegree_")]
    public float EnabledBackDegree { get; set; }

    [JsonPropertyName("animIdList_")]
    public BindingList<string> AnimIdList { get; set; }

    [JsonPropertyName("isChangeAnimMovementRate_")]
    public bool IsChangeAnimMovementRate { get; set; }

    [JsonPropertyName("animMovementRate_")]
    public cVec4 AnimMovementRate { get; set; }

    [JsonPropertyName("isCalcDirbyAttackerPos_")]
    public bool IsCalcDirbyAttackerPos { get; set; }

    [JsonPropertyName("animBlendEaseFrame_")]
    public int AnimBlendEaseFrame { get; set; }

    [JsonPropertyName("animBlendRate_")]
    public float AnimBlendRate { get; set; }

    [JsonPropertyName("animStartFrame_")]
    public int AnimStartFrame { get; set; }

    [JsonPropertyName("animStartStep_")]
    public int AnimStartStep { get; set; }

    [JsonPropertyName("animSpeedRate_")]
    public float AnimSpeedRate { get; set; }

    [JsonPropertyName("animSpeedStep_")]
    public int AnimSpeedStep { get; set; }
}
