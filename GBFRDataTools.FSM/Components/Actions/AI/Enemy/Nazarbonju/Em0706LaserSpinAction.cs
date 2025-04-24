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
    public CharaFlyParam FlyParam { get; set; } // Offset 0x208

    [JsonPropertyName("laserSpinParams_")]
    public BindingList<LaserSpinParam> LaserSpinParams { get; set; } = []; // Offset 0x228

    [JsonPropertyName("nearLength_")]
    public float NearLength { get; set; } = 5f; // Offset 0x248

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 1f; // Offset 0x24C

    [JsonPropertyName("detourMoveSpeed_")]
    public float DetourMoveSpeed { get; set; } = 0.2f; // Offset 0x250

    [JsonPropertyName("detourMoveSec_")]
    public float DetourMoveSec { get; set; } = 2f; // Offset 0x254

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.5f; // Offset 0x244

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 1f; // Offset 0x240

    [JsonPropertyName("checkDetourLength_")]
    public float CheckDetourLength { get; set; } = 6f; // Offset 0x258

    [JsonPropertyName("checkDetourHeight_")]
    public float CheckDetourHeight { get; set; } = 1.5f; // Offset 0x25C

    [JsonPropertyName("useAddSpeedSystem_")]
    public bool UseAddSpeedSystem { get; set; } = false; // Offset 0x260

    [JsonPropertyName("bodyTurnDegXSpdAdd_")]
    public float BodyTurnDegXSpdAdd { get; set; } = 0.3f; // Offset 0x264

    [JsonPropertyName("bodyTurnDegXSpdMax_")]
    public float BodyTurnDegXSpdMax { get; set; } = 3.5f; // Offset 0x268

    [JsonPropertyName("paramRepeatNumMax_")]
    public int ParamRepeatNumMax { get; set; } = 0; // Offset 0x270

    [JsonPropertyName("paramRepeatStartId_")]
    public int ParamRepeatStartId { get; set; } = 0; // Offset 0x26C

    [JsonPropertyName("spinEndLandingLoopSec_")]
    public float SpinEndLandingLoopSec { get; set; } = 3f; // Offset 0x274

    [JsonPropertyName("spinEndAnimInterTime_")]
    public float SpinEndAnimInterTime { get; set; } = 0.5f; // Offset 0x278

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; } = 2300; // Offset 0x27C

    [JsonPropertyName("openFlyParam_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public bool OpenFlyParam { get; set; }

    public Em0706LaserSpinAction()
    {
    }

    public class LaserSpinParam
    {

        [JsonPropertyName("flyHeight_")]
        public float FlyHeight { get; set; } // Offset 0x8

        [JsonPropertyName("laserLoopSec_")]
        public float LaserLoopSec { get; set; } // Offset 0xC

        [JsonPropertyName("transitionSpdRate_")]
        public Vector2 TransitionSpdRate { get; set; } // Offset 0x10

        [JsonPropertyName("transitionSpdRateTime_")]
        public float TransitionSpdRateTime { get; set; } // Offset 0x18

        [JsonPropertyName("transitionSpdRatePower_")]
        public int TransitionSpdRatePower { get; set; } // Offset 0x1C

        [JsonPropertyName("addLaserOffsetDegX_")]
        public float AddLaserOffsetDegX { get; set; } // Offset 0x20

        [JsonPropertyName("bodyDegX_")]
        public float BodyDegX { get; set; } // Offset 0x24

        [JsonPropertyName("showParamInfo_")]
        [Obsolete("Not used by the game")]
        [Description("Not used by the game")]
        public bool ShowParamInfo { get; set; }

        public LaserSpinParam()
        {
        }
    }
}