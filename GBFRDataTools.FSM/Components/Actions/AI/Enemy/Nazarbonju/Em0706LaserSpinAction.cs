using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0706LaserSpinAction : Em0706BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706LaserSpinAction);

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } = new();

    [JsonPropertyName("laserSpinParams_")]
    public BindingList<LaserSpinParam> LaserSpinParams { get; set; } = []; 

    [JsonPropertyName("nearLength_")]
    public float NearLength { get; set; } = 5f; 

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 1f; 

    [JsonPropertyName("detourMoveSpeed_")]
    public float DetourMoveSpeed { get; set; } = 0.2f; 

    [JsonPropertyName("detourMoveSec_")]
    public float DetourMoveSec { get; set; } = 2f; 

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.5f; 

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 1f; 

    [JsonPropertyName("checkDetourLength_")]
    public float CheckDetourLength { get; set; } = 6f; 

    [JsonPropertyName("checkDetourHeight_")]
    public float CheckDetourHeight { get; set; } = 1.5f; 

    [JsonPropertyName("useAddSpeedSystem_")]
    public bool UseAddSpeedSystem { get; set; } = false; 

    [JsonPropertyName("bodyTurnDegXSpdAdd_")]
    public float BodyTurnDegXSpdAdd { get; set; } = 0.3f; 

    [JsonPropertyName("bodyTurnDegXSpdMax_")]
    public float BodyTurnDegXSpdMax { get; set; } = 3.5f; 

    [JsonPropertyName("paramRepeatNumMax_")]
    public int ParamRepeatNumMax { get; set; } = 0; 

    [JsonPropertyName("paramRepeatStartId_")]
    public int ParamRepeatStartId { get; set; } = 0; 

    [JsonPropertyName("spinEndLandingLoopSec_")]
    public float SpinEndLandingLoopSec { get; set; } = 3f; 

    [JsonPropertyName("spinEndAnimInterTime_")]
    public float SpinEndAnimInterTime { get; set; } = 0.5f; 

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; } = 2300; 

    [JsonPropertyName("openFlyParam_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public bool OpenFlyParam { get; set; }

    public class LaserSpinParam
    {
        [JsonPropertyName("flyHeight_")]
        public float FlyHeight { get; set; } 

        [JsonPropertyName("laserLoopSec_")]
        public float LaserLoopSec { get; set; } 

        [JsonPropertyName("transitionSpdRate_")]
        public Vector2 TransitionSpdRate { get; set; } 

        [JsonPropertyName("transitionSpdRateTime_")]
        public float TransitionSpdRateTime { get; set; } 

        [JsonPropertyName("transitionSpdRatePower_")]
        public int TransitionSpdRatePower { get; set; } 

        [JsonPropertyName("addLaserOffsetDegX_")]
        public float AddLaserOffsetDegX { get; set; } 

        [JsonPropertyName("bodyDegX_")]
        public float BodyDegX { get; set; } 

        [JsonPropertyName("showParamInfo_")]
        [Obsolete("Not used by the game")]
        [Description("Not used by the game")]
        public bool ShowParamInfo { get; set; }
    }
}