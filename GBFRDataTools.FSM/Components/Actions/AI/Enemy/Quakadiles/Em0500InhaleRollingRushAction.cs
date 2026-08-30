using GBFRDataTools.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em0500InhaleRollingRushAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500InhaleRollingRushAction);

    [JsonPropertyName("maxSeconds_")]
    public float MaxSeconds { get; set; } = 10f;

    [JsonPropertyName("initialSpeed_")]
    public float InitialSpeed { get; set; } = 17f;

    [JsonPropertyName("accel_")]
    public float Accel { get; set; } = 0.5f;

    [JsonPropertyName("addSpeed_")]
    public float AddSpeed { get; set; } = 0f;

    [JsonPropertyName("maxSpeed_")]
    public float MaxSpeed { get; set; } = 40f;

    [JsonPropertyName("refrectAngle_")]
    public float RefrectAngle { get; set; } = 60f;

    [JsonPropertyName("showSignLineMax_")]
    public int ShowSignLineMax { get; set; } = 2;

    [JsonPropertyName("totalSignSec_")]
    public float TotalSignSec { get; set; } = 5f;

    [JsonPropertyName("driftSpeedMag_")]
    public float DriftSpeedMag { get; set; } = 0.98f;

    [JsonPropertyName("driftAttackRadius_")]
    public float DriftAttackRadius { get; set; } = 2.8f;

    [JsonPropertyName("driftAttackLength_")]
    public float DriftAttackLength { get; set; } = 4.5f;

    [JsonPropertyName("slowDownLength_")]
    public float SlowDownLength { get; set; } = 25f;

    [JsonPropertyName("smokeAttackOffset_")]
    public Vector4 SmokeAttackOffset { get; set; } = new Vector4(-5f, 1f, -3f, 1f);

    [JsonPropertyName("smokeAttackWaitFrame_")]
    public int SmokeAttackWaitFrame { get; set; } = 3;

    [JsonPropertyName("smokeAttackRemainFrame_")]
    public int SmokeAttackRemainFrame { get; set; } = 3;

    [JsonPropertyName("remainAttackLength_")]
    public float RemainAttackLength { get; set; } = 1f;

    [JsonPropertyName("remainAttackRadius_")]
    public float RemainAttackRadius { get; set; } = 2f;

    [JsonPropertyName("remainAttackOffset_")]
    public Vector4 RemainAttackOffset { get; set; } = new Vector4(-5f, 0f, -3f, 1f);

    [JsonPropertyName("driftAttackRate_")]
    public float DriftAttackRate { get; set; } = 1f;

    [JsonPropertyName("driftBreakRate_")]
    public float DriftBreakRate { get; set; } = 1f;

    [JsonPropertyName("remainDriftFrame_")]
    public int RemainDriftFrame { get; set; } = 6;

    [JsonPropertyName("adjustCollisionRadius_")]
    public float AdjustCollisionRadius { get; set; } = 2f;

    [JsonPropertyName("finalRollingSec_")]
    public float FinalRollingSec { get; set; } = 3f;

    [JsonPropertyName("rollingOffsetY_")]
    public float RollingOffsetY { get; set; } = 2.5f;

    [JsonPropertyName("rollingGravityRate_")]
    public float RollingGravityRate { get; set; } = 100f;

    [JsonPropertyName("cameraSec_")]
    public float CameraSec { get; set; } = 5f;

    [JsonPropertyName("param_")]
    public VacuumeParam Param { get; set; } = new();

    [JsonPropertyName("startParam_")]
    public VacuumeParam StartParam { get; set; } = new();

    [JsonPropertyName("startPoints_")]
    public BindingList<StartPoint> StartPoints { get; set; } = []; // std::vector<BT::Em0500InhaleRollingRushAction::StartPoint>

    [JsonPropertyName("backMoveTimeoutSec_")]
    public float BackMoveTimeoutSec { get; set; } = 1.8f;

    [JsonPropertyName("backMoveMovementRate_")]
    public float BackMoveMovementRate { get; set; } = 1f;

    [JsonPropertyName("backMoveArriveDistance_")]
    public float BackMoveArriveDistance { get; set; } = 0.3f;

    [JsonPropertyName("backMoveMinDistance_")]
    public float BackMoveMinDistance { get; set; } = 1.5f;

    [JsonPropertyName("backMoveShortDistance_")]
    public float BackMoveShortDistance { get; set; } = 10f;

    [JsonPropertyName("backMoveMinTurnDeg_")]
    public float BackMoveMinTurnDeg { get; set; } = 10f;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class VacuumeParam /* Em0500InhaleRollingRushAction::VacuumeParam */
    {
        [JsonPropertyName("vacuumeSpeed_")]
        public float VacuumeSpeed { get; set; }
    
        [JsonPropertyName("vacuumeDistance_")]
        public float VacuumeDistance { get; set; }
    
        [JsonPropertyName("vacuumeFrontDistance_")]
        public float VacuumeFrontDistance { get; set; }
    
        [JsonPropertyName("vacuumeMinDistance_")]
        public float VacuumeMinDistance { get; set; }
    
        [JsonPropertyName("vacuumeAngle_")]
        public float VacuumeAngle { get; set; }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StartPoint /* Em0500InhaleRollingRushAction::StartPoint */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    
        [JsonPropertyName("yawDeg_")]
        public float YawDeg { get; set; }
    }
}