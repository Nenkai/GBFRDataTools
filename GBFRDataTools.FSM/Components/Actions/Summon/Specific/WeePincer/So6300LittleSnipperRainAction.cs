using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.WeePincer;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So6300LittleSnipperRainAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So6300LittleSnipperRainAction);

    [JsonPropertyName("scale_")]
    public Vector4 Scale { get; set; } = Vector4.UnitW;

    [JsonPropertyName("fallPosCenterOffset_")]
    public Vector4 FallPosCenterOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("fallHideFrameMax_")]
    public int FallHideFrameMax { get; set; } = 3;

    [JsonPropertyName("fallBaseOffset_")]
    public Vector4 FallBaseOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("fallRandomOffsetLineMax_")]
    public int FallRandomOffsetLineMax { get; set; } = 7;

    [JsonPropertyName("fallRandomOffsetColumnMax_")]
    public int FallRandomOffsetColumnMax { get; set; } = 7;

    [JsonPropertyName("fallRandomOffset_")]
    public Vector4 FallRandomOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("fallAnimDirection_")]
    public float FallAnimDirection { get; set; } = -1f;

    [JsonPropertyName("fallParam_")]
    public FallParam_ FallParam { get; set; } = new(); // BT::So6300LittleSnipperRainAction::FallParam

    [JsonPropertyName("loopSeEventName_")]
    public string LoopSeEventName { get; set; }

    [JsonPropertyName("loopSeStopEventName_")]
    public string LoopSeStopEventName { get; set; }

    [JsonPropertyName("loopSeSwitchGroupName_")]
    public string LoopSeSwitchGroupName { get; set; }

    [JsonPropertyName("loopSeCheckMaterialIntervalFrame_")]
    public int LoopSeCheckMaterialIntervalFrame { get; set; } = 10;

    [JsonPropertyName("loopSeFloorCheckHeightHigh_")]
    public float LoopSeFloorCheckHeightHigh { get; set; } = 1f;

    [JsonPropertyName("loopSeFloorCheckHeightLow_")]
    public float LoopSeFloorCheckHeightLow { get; set; } = -1f;

    [JsonPropertyName("fallPosControlFrame_")]
    public int FallPosControlFrame { get; set; } = 120;

    [JsonPropertyName("fallPosMoveSpeed_")]
    public float FallPosMoveSpeed { get; set; } = 5f;

    [JsonPropertyName("fallPosCheckLineLength_")]
    public float FallPosCheckLineLength { get; set; } = 0.8f;

    [JsonPropertyName("fallPosCheckLineOffsetY_")]
    public float FallPosCheckLineOffsetY { get; set; } = 1f;

    [JsonPropertyName("fallPosCheckLineAdjustRate_")]
    public float FallPosCheckLineAdjustRate { get; set; } = 0.7f;

    [JsonPropertyName("fallPosGroundCheckHeight_")]
    public float FallPosGroundCheckHeight { get; set; } = 1f;

    [JsonPropertyName("fallPosGroundRotLimit_")]
    public float FallPosGroundRotLimit { get; set; } = 50f;

    [JsonPropertyName("fallPosMovingAdjustRate_")]
    public float FallPosMovingAdjustRate { get; set; } = 1f;

    [JsonPropertyName("terminateDelay_")]
    public float TerminateDelay { get; set; } = 0.5f;

    [JsonPropertyName("isCheckCollision_")]
    public bool IsCheckCollision { get; set; } = true;

    [JsonPropertyName("isAdjustFloor_")]
    public bool IsAdjustFloor { get; set; } = true;

    public class FallParam_ /* So6300LittleSnipperRainAction::FallParam */
    {
        [JsonPropertyName("effectId_")]
        public int EffectId { get; set; }
    
        [JsonPropertyName("effectStartFrame_")]
        public int EffectStartFrame { get; set; }
    
        [JsonPropertyName("fallStartSignFrame_")]
        public int FallStartSignFrame { get; set; }
    
        [JsonPropertyName("fallStartSignSize_")]
        public Vector4 FallStartSignSize { get; set; }
    
        [JsonPropertyName("signStartTimeFrame_")]
        public int SignStartTimeFrame { get; set; }

        [JsonPropertyName("fallAttackParams_")]
        public BindingList<FallAttackParam> FallAttackParams { get; set; } = [];
    
        [JsonPropertyName("loopSeSwitchStateName_")]
        public string LoopSeSwitchStateName { get; set; }
    }

    public class FallAttackParam /* So6300LittleSnipperRainAction::FallAttackParam */
    {
        [JsonPropertyName("phaseNum_")]
        public int PhaseNum { get; set; }
    
        [JsonPropertyName("snipperLifeTimeFrame_")]
        public int SnipperLifeTimeFrame { get; set; }
    
        [JsonPropertyName("snipperEndEffectFrame_")]
        public int SnipperEndEffectFrame { get; set; }
    
        [JsonPropertyName("fallCount_")]
        public int FallCount { get; set; }
    
        [JsonPropertyName("fallIntervalFrame_")]
        public int FallIntervalFrame { get; set; }
    
        [JsonPropertyName("waitFrame_")]
        public int WaitFrame { get; set; }

        [JsonPropertyName("fallPatterns_")]
        public BindingList<int> FallPatterns { get; set; } = [];

        [JsonPropertyName("attackParam_")]
        public AttackParam AttackParam { get; set; } = new();
    }

    public class AttackParam /* So6300LittleSnipperRainAction::AttackParam */
    {
        [JsonPropertyName("attackRate_")]
        public float AttackRate { get; set; } // Offset 0x10
    
        [JsonPropertyName("breakRate_")]
        public float BreakRate { get; set; } // Offset 0x14
    
        [JsonPropertyName("attackSize_")]
        public Vector4 AttackSize { get; set; } // Offset 0x20
    
        [JsonPropertyName("attackOffsetY_")]
        public float AttackOffsetY { get; set; }
    
        [JsonPropertyName("spArtsRate_")]
        public float SpArtsRate { get; set; }
    
        [JsonPropertyName("hitStopSec_")]
        public float HitStopSec { get; set; }
    
        [JsonPropertyName("attackStartFrame_")]
        public int AttackStartFrame { get; set; }
    
        [JsonPropertyName("attackFrame_")]
        public int AttackFrame { get; set; }
    
        [JsonPropertyName("attackMultiHitIntervalFrame_")]
        public int AttackMultiHitIntervalFrame { get; set; }
    
        [JsonPropertyName("attackCount_")]
        public int AttackCount { get; set; }
    
        [JsonPropertyName("attackIntervalFrame_")]
        public int AttackIntervalFrame { get; set; }
    
        [JsonPropertyName("reaction_")]
        public int Reaction { get; set; }
    }
}