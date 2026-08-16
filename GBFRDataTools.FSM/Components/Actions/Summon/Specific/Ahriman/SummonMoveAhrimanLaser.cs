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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Ahriman;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonMoveAhrimanLaser : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonMoveAhrimanLaser);

    [JsonPropertyName("laserSpinParams_")]
    public BindingList<LaserMoveParam> LaserSpinParams { get; set; } = new();

    [JsonPropertyName("animSpeedBBName_")]
    public string AnimSpeedBBName { get; set; }

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

    [JsonPropertyName("maxSpinSpeed_")]
    public float MaxSpinSpeed { get; set; } = 10f;

    public class LaserMoveParam /* SummonMoveAhrimanLaser::LaserMoveParam */
    {
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
    }
}
