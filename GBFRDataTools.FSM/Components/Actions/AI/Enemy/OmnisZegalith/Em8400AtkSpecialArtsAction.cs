using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Entities;

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
public class Em8400AtkSpecialArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkSpecialArtsAction);

    [JsonPropertyName("isCallStageVFX_")]
    public bool IsCallStageVFX { get; set; } = true;

    [JsonPropertyName("isEnableMotionShip_")]
    public bool IsEnableMotionShip { get; set; } = false;

    [JsonPropertyName("limitTimeSec_")]
    public float LimitTimeSec { get; set; } = 60f;

    [JsonPropertyName("playerClearEndDistance_")]
    public float PlayerClearEndDistance { get; set; } = -15f;

    [JsonPropertyName("goalDistance_")]
    public BindingList<float> GoalDistance { get; set; } = [..Enumerable.Repeat(0.0f, 3)]; // std::array<float,3>

    [JsonPropertyName("coreHpPercent_")]
    public float CoreHpPercent { get; set; } = 1.5f;

    [JsonPropertyName("attackDisableFrame_")]
    public BindingList<int> AttackDisableFrame { get; set; } = [.. Enumerable.Repeat(0, 3)]; // std::array<int,3>

    [JsonPropertyName("randomShotCreateDisableDistance_")]
    public float RandomShotCreateDisableDistance { get; set; } = 15f;

    [JsonPropertyName("playerNpcSpArtsLimitTimePercent_")]
    public float PlayerNpcSpArtsLimitTimePercent { get; set; } = 10f;

    [JsonPropertyName("playerNpcSpArtsLimitHpPercent_")]
    public float PlayerNpcSpArtsLimitHpPercent { get; set; } = 50f;

    [JsonPropertyName("phaseOffsetPos_")]
    public BindingList<Vector4> PhaseOffsetPos { get; set; } = [.. Enumerable.Repeat(Vector4.Zero, 3)]; // std::array<Hw::cVec4,3>

    [JsonPropertyName("gateVFXPosRot_")]
    public BindingList<Vector4> GateVFXPosRot { get; set; } = [.. Enumerable.Repeat(Vector4.Zero, 3)]; // std::array<Hw::cVec4,3>

    [JsonPropertyName("playerStartPos_")]
    public BindingList<Vector4> PlayerStartPos { get; set; } = [.. Enumerable.Repeat(Vector4.Zero, 3)]; // std::array<Hw::cVec4,3>

    [JsonPropertyName("shotPosParameterBy1stArea_")]
    public BindingList<ShotParameter> ShotPosParameterBy1stArea { get; set; } = []; // std::vector<BT::Em8400AtkSpecialArtsAction::ShotParameter>

    [JsonPropertyName("shotPosParameterBy2ndArea_")]
    public BindingList<ShotParameter> ShotPosParameterBy2ndArea { get; set; } = []; // std::vector<BT::Em8400AtkSpecialArtsAction::ShotParameter>

    [JsonPropertyName("shotPosParameterBy3rdArea_")]
    public BindingList<ShotParameter> ShotPosParameterBy3rdArea { get; set; } = []; // std::vector<BT::Em8400AtkSpecialArtsAction::ShotParameter>

    [JsonPropertyName("bigStoneParameter_")]
    public BindingList<BigStoneParameter_> BigStoneParameter { get; set; } = []; // std::vector<BT::Em8400AtkSpecialArtsAction::BigStoneParameter>>

    [JsonPropertyName("fallRockParameter_")]
    public BindingList<FallRockParameter_> FallRockParameter { get; set; } = []; // std::vector<BT::Em8400AtkSpecialArtsAction::FallRockParameter>

    [JsonPropertyName("fallRockParameterBy3rdArea_")]
    public BindingList<FallRockParameter_> FallRockParameterBy3rdArea { get; set; }

    [JsonPropertyName("tornadoParameter_")]
    public BindingList<TornadoParameter_> TornadoParameter { get; set; } = []; // std::vector<BT::Em8400AtkSpecialArtsAction::TornadoParameter>

    [JsonPropertyName("phaseAttackSetParam_")]
    public BindingList<PhaseAttackSetParameter> PhaseAttackSetParam { get; set; } = [..Enumerable.Repeat(new PhaseAttackSetParameter(), 5)]; // std::array<BT::Em8400AtkSpecialArtsAction::PhaseAttackSetParameter,5>

    [JsonPropertyName("meteorNotHomingDistance_")]
    public float MeteorNotHomingDistance { get; set; } = 15f;

    [JsonPropertyName("coreDummyOffset_")]
    public Vector4 CoreDummyOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("shipCreatePos_")]
    public Vector4 ShipCreatePos { get; set; } = new Vector4(77.8455f, -38.9144f, 171.2361f, 1f);

    [JsonPropertyName("playerGravityRate_")]
    public float PlayerGravityRate { get; set; } = 0.5f;

    [JsonPropertyName("playerFallStartSpeed_")]
    public float PlayerFallStartSpeed { get; set; } = 0f;

    [JsonPropertyName("playerFallTimeSec_")]
    public float PlayerFallTimeSec { get; set; } = 0f;

    [JsonPropertyName("dpsCheckClearVFXFrame_")]
    public int DpsCheckClearVFXFrame { get; set; } = 240;

    [JsonPropertyName("dummyAttackParameter1stArea_")]
    public BindingList<DummyAttackParameter> DummyAttackParameter1stArea { get; set; } = []; // std::vector<BT::Em8400AtkSpecialArtsAction::DummyAttackParameter>

    [JsonPropertyName("dummyAttackParameter3rdArea_")]
    public BindingList<DummyAttackParameter> DummyAttackParameter3rdArea { get; set; } = []; // std::vector<BT::Em8400AtkSpecialArtsAction::DummyAttackParameter>

    [JsonPropertyName("startCameraTargetOffset_")]
    public Vector4 StartCameraTargetOffset { get; set; } = new Vector4(0f, -180f, 0f, 1f);

    [JsonPropertyName("startTelopDelayTime_")]
    public float StartTelopDelayTime { get; set; } = 2f; 

    [JsonPropertyName("actionEndIntervalBySuccess_")]
    public float ActionEndIntervalBySuccess { get; set; } = 3f;

    [JsonPropertyName("actionEndIntervalByFailed_")]
    public float ActionEndIntervalByFailed { get; set; } = 3f;

    [JsonPropertyName("isEnableAttackRushMode_")]
    public bool IsEnableAttackRushMode { get; set; } = false;

    [JsonPropertyName("attackRushStartHpPercent_")]
    public float AttackRushStartHpPercent { get; set; } = 90f;

    [JsonPropertyName("attackRushIntervalSec_")]
    public float AttackRushIntervalSec { get; set; } = 8f;

    [JsonPropertyName("attackRushTimeSec_")]
    public float AttackRushTimeSec { get; set; } = 10f;

    [JsonPropertyName("attackRushRapidSec_")]
    public float AttackRushRapidSec { get; set; } = 0.7f;

    [JsonPropertyName("attackRushHomingSec_")]
    public float AttackRushHomingSec { get; set; } = 1.5f;

    [JsonPropertyName("meleeCameraChangeDist_")]
    public float MeleeCameraChangeDist { get; set; } = 20f;

    [JsonPropertyName("normalCameraChangeDist_")]
    public float NormalCameraChangeDist { get; set; } = 25f;

    [JsonPropertyName("phase3StartCamTarget_")]
    public EmPositionParam Phase3StartCamTarget { get; set; } = new();

    public class ShotParameter /* Em8400AtkSpecialArtsAction::ShotParameter */
    {
        [JsonPropertyName("pos_")]
        public EmPositionParam Pos { get; set; }
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }
    
        [JsonPropertyName("triggerDistance_")]
        public float TriggerDistance { get; set; }
    
        [JsonPropertyName("triggerBBName_")]
        public string TriggerBBName { get; set; }
    
        [JsonPropertyName("fsmName_")]
        public string FsmName { get; set; }
    }

    public class BigStoneParameter_ /* Em8400AtkSpecialArtsAction::BigStoneParameter */
    {
        [JsonPropertyName("pos_")]
        public EmPositionParam Pos { get; set; } 
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }
    
        [JsonPropertyName("fsmName_")]
        public string FsmName { get; set; }
    
        [JsonPropertyName("delayFrame_")]
        public int DelayFrame { get; set; }
    }

    public class FallRockParameter_ /* Em8400AtkSpecialArtsAction::FallRockParameter */
    {
        [JsonPropertyName("isEnableBehindCreate_")]
        public bool IsEnableBehindCreate { get; set; }
    
        [JsonPropertyName("canCreateDistance_")]
        public float CanCreateDistance { get; set; }
    
        [JsonPropertyName("canNotCreateDistance_")]
        public float CanNotCreateDistance { get; set; }
    
        [JsonPropertyName("posParam_")]
        public EmPositionParam PosParam { get; set; }
    }

    public class TornadoParameter_ /* Em8400AtkSpecialArtsAction::TornadoParameter */
    {
        [JsonPropertyName("isWindWall_")]
        public bool IsWindWall { get; set; }

        [JsonPropertyName("rotY_")]
        public float RotY { get; set; } = 0.0f;

        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }

        [JsonPropertyName("attackTimeSec_")]
        public float AttackTimeSec { get; set; } = 5.0f;

        [JsonPropertyName("attackTimeSecRandom_")]
        public float AttackTimeSecRandom { get; set; } = 1.0f;

        [JsonPropertyName("createIntervalTimeSec_")]
        public float CreateIntervalTimeSec { get; set; } = 5.0f;

        [JsonPropertyName("createIntervalTimeSecRandom_")]
        public float CreateIntervalTimeSecRandom { get; set; }
    
        [JsonPropertyName("firstDelayTimeSec_")]
        public float FirstDelayTimeSec { get; set; }

        [JsonPropertyName("fsmName_")]
        public string FsmName { get; set; } = "shot_sparts_tornado";

        [JsonPropertyName("size_")]
        public Vector4 Size { get; set; } = Vector4.UnitW;
    
        [JsonPropertyName("lineSeStartPos_")]
        public Vector4 LineSeStartPos { get; set; } = Vector4.UnitW;

        [JsonPropertyName("lineSeEndPos_")]
        public Vector4 LineSeEndPos { get; set; } = Vector4.UnitW;

        [JsonPropertyName("pos_")]
        public EmPositionParam Pos { get; set; }
    }

    public class DummyAttackParameter /* Em8400AtkSpecialArtsAction::DummyAttackParameter */
    {
        [JsonPropertyName("fsmName_")]
        public string FsmName { get; set; } = "shot_sparts_meteor";

        [JsonPropertyName("posParam_")]
        public EmPositionParam PosParam { get; set; }
    }

    public class PhaseAttackSetParameter /* Em8400AtkSpecialArtsAction::PhaseAttackSetParameter */
    {
        [JsonPropertyName("fallRockCreateIntervalFrame_")]
        public int FallRockCreateIntervalFrame { get; set; } = 240;

        [JsonPropertyName("fallRockRandomIntervalFrame_")]
        public int FallRockRandomIntervalFrame { get; set; } = 60;

        [JsonPropertyName("fallRockTargetSerchIntervalFrame_")]
        public int FallRockTargetSerchIntervalFrame { get; set; } = 180;

        [JsonPropertyName("fallRockRapidNumMax_")]
        public int FallRockRapidNumMax { get; set; } = 3;

        [JsonPropertyName("fallRockRapidFrame_")]
        public int FallRockRapidFrame { get; set; } = 10;

        [JsonPropertyName("fallRockRapidPercent_")]
        public int FallRockRapidPercent { get; set; } = 0;

        [JsonPropertyName("fallRockOffsetRandomValue_")]
        public int FallRockOffsetRandomValue { get; set; } = 2;

        [JsonPropertyName("fallRockRandomOffsetDist_")]
        public float FallRockRandomOffsetDist { get; set; } = 2.0f;

        [JsonPropertyName("nextPhaseChangeLinePosZ_")]
        public float NextPhaseChangeLinePosZ { get; set; } = 1000.0f;

        [JsonPropertyName("straightShotFsmName_")]
        public string StraightShotFsmName { get; set; } = "shot_sparts_rock";

        [JsonPropertyName("circleAttackFsmName_")]
        public string CircleAttackFsmName { get; set; } = "shot_sparts_fall_rock";

        [JsonPropertyName("dummyAttackIntervalFrame_")]
        public int DummyAttackIntervalFrame { get; set; } = 60;

        [JsonPropertyName("dummyAttackRandomIntervalFrame_")]
        public int DummyAttackRandomIntervalFrame { get; set; } = 10;
    }
}
