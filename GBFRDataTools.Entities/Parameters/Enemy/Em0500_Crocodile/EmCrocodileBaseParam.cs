using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0500_Crocodile;

public class EmCrocodileBaseParam : EmBossBaseParam
{
    [JsonPropertyName("partsBreakHp_")]
    public /* cVec3 */ Vector3 PartsBreakHp { get; set; }

    [JsonPropertyName("partsBreakWeakPointParam_")]
    public EmWeakPointParam PartsBreakWeakPointParam { get; set; }

    [JsonPropertyName("highVoltageRushAtkRate_")]
    public /* cVec2 */ Vector2 HighVoltageRushAtkRate { get; set; }

    [JsonPropertyName("highVoltagePushUpAtkRate_")]
    public /* cVec2 */ Vector2 HighVoltagePushUpAtkRate { get; set; }

    [JsonPropertyName("rollingFinalRushAtkRate_")]
    public /* cVec2 */ Vector2 RollingFinalRushAtkRate { get; set; }

    [JsonPropertyName("addMotionRate_")]
    public float AddMotionRate { get; set; }

    [JsonPropertyName("strongAnimInterpSec_")]
    public float StrongAnimInterpSec { get; set; }

    [JsonPropertyName("overDriveAnimRateAILv3_4_")]
    public /* cVec2 */ Vector2 OverDriveAnimRateAILv3_4 { get; set; }

    [JsonPropertyName("overDriveHpRateAILv3_4_")]
    public /* cVec4 */ Vector4 OverDriveHpRateAILv3_4 { get; set; }

    [JsonPropertyName("overDriveHpRateTutorial_")]
    public /* cVec4 */ Vector4 OverDriveHpRateTutorial { get; set; }

    [JsonPropertyName("coolTimeMeleeCombo_")]
    public /* cVec2 */ Vector2 CoolTimeMeleeCombo { get; set; }

    [JsonPropertyName("coolTimeMeleeComboOD_")]
    public /* cVec2 */ Vector2 CoolTimeMeleeComboOD { get; set; }

    [JsonPropertyName("coolTimeMeleeComboTutorial_")]
    public /* cVec2 */ Vector2 CoolTimeMeleeComboTutorial { get; set; }

    [JsonPropertyName("coolTimeBite_")]
    public /* cVec2 */ Vector2 CoolTimeBite { get; set; }

    [JsonPropertyName("coolTimeShot_")]
    public /* cVec2 */ Vector2 CoolTimeShot { get; set; }

    [JsonPropertyName("coolTimeVacuumBite_")]
    public /* cVec2 */ Vector2 CoolTimeVacuumBite { get; set; }

    [JsonPropertyName("coolTimeRushPushUp_")]
    public /* cVec2 */ Vector2 CoolTimeRushPushUp { get; set; }

    [JsonPropertyName("coolTimeRushPushUpTutorial_")]
    public /* cVec2 */ Vector2 CoolTimeRushPushUpTutorial { get; set; }

    [JsonPropertyName("coolTimeWatching_")]
    public /* cVec2 */ Vector2 CoolTimeWatching { get; set; }

    [JsonPropertyName("coolTimeJumpRush_")]
    public /* cVec2 */ Vector2 CoolTimeJumpRush { get; set; }

    [JsonPropertyName("entanglePlNum_")]
    public int EntanglePlNum { get; set; }

    [JsonPropertyName("slamCheckCount")]
    public int SlamCheckCount { get; set; }

    [JsonPropertyName("highVoltageRushCount_")]
    public int HighVoltageRushCount { get; set; }

    [JsonPropertyName("spreadShotAngle_")]
    public float SpreadShotAngle { get; set; }

    [JsonPropertyName("gayserRadialDivRot_")]
    public float GayserRadialDivRot { get; set; }

    [JsonPropertyName("gayserAddLength_")]
    public float GayserAddLength { get; set; }

    [JsonPropertyName("gayserInitLength_")]
    public /* cVec2 */ Vector2 GayserInitLength { get; set; }

    [JsonPropertyName("gayserNoSetLengthEm0500_")]
    public float GayserNoSetLengthEm0500 { get; set; }

    [JsonPropertyName("gayserNoSetLengthGayser_")]
    public float GayserNoSetLengthGayser { get; set; }

    [JsonPropertyName("gayserNoSetLengthInitPos_")]
    public float GayserNoSetLengthInitPos { get; set; }

    [JsonPropertyName("gayserRandPos_")]
    public float GayserRandPos { get; set; }

    [JsonPropertyName("gayserLineMax_")]
    public int GayserLineMax { get; set; }

    [JsonPropertyName("gayserInitDelayTime_")]
    public /* cVec2 */ Vector2 GayserInitDelayTime { get; set; }

    [JsonPropertyName("gayserInitDelayDistance_")]
    public /* cVec2 */ Vector2 GayserInitDelayDistance { get; set; }

    [JsonPropertyName("gayserRockHp_")]
    public int GayserRockHp { get; set; }

    [JsonPropertyName("gayserRockBreak_")]
    public int GayserRockBreak { get; set; }

    [JsonPropertyName("rockCrushNum_")]
    public int RockCrushNum { get; set; }

    [JsonPropertyName("rockCrushRange_")]
    public /* cVec2 */ Vector2 RockCrushRange { get; set; }

    [JsonPropertyName("rockCrushPosRand_")]
    public float RockCrushPosRand { get; set; }

    [JsonPropertyName("rockCrushDisengageRange_")]
    public float RockCrushDisengageRange { get; set; }

    [JsonPropertyName("rockCrushTime_")]
    public /* cVec2 */ Vector2 RockCrushTime { get; set; }

    [JsonPropertyName("rollingAnimBlendAnglePerRate_")]
    public float RollingAnimBlendAnglePerRate { get; set; }

    [JsonPropertyName("rollingAnimBlendAddRate_")]
    public float RollingAnimBlendAddRate { get; set; }

    [JsonPropertyName("rollingEffectRate_")]
    public float RollingEffectRate { get; set; }

    [JsonPropertyName("addDamageParam_")]
    public EmAddDamageParam AddDamageParam { get; set; }

    [JsonPropertyName("tutorialStunGauge_")]
    public float TutorialStunGauge { get; set; }

    [JsonPropertyName("tutorialHpLimit_")]
    public /* cVec4 */ Vector4 TutorialHpLimit { get; set; }

    [JsonPropertyName("tutorialNoMoveAction_")]
    public float TutorialNoMoveAction { get; set; }

    [JsonPropertyName("tutorialLockOnParam_")]
    public EmLockOnParam TutorialLockOnParam { get; set; }
}
