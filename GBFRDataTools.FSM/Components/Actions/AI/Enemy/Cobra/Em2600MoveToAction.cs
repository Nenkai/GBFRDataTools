using GBFRDataTools.FSM.Components.Actions.Battle;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;

public class Em2600MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2600MoveToAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.5f; 

    [JsonPropertyName("moveRate_")]
    public float MoveRate { get; set; } = 1f; 

    [JsonPropertyName("wallDegX_")]
    public float WallDegX { get; set; } = 60f; 

    [JsonPropertyName("isCheckTarget_")]
    public bool IsCheckTarget { get; set; } = false; 

    [JsonPropertyName("checkNearTargetLength_")]
    public float CheckNearTargetLength { get; set; } = 0f; 

    [JsonPropertyName("isRouteMove_")]
    public bool IsRouteMove { get; set; } = false; 

    [JsonPropertyName("isAppearAgain_")]
    public bool IsAppearAgain { get; set; } = false; 

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 10f; 

    [JsonPropertyName("wallHitMoveSecRate_")]
    public float WallHitMoveSecRate { get; set; } = 5f; 

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; 

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; 

    [JsonPropertyName("moveTargetType_")]
    public int MoveTargetType { get; set; } = 0; 

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; } = 102; 

    [JsonPropertyName("routeParams_")]
    public BindingList<RouteParam> RouteParams { get; set; } = []; 

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class RouteParam
    {
        [JsonPropertyName("isOwnerOffset_")]
        public bool IsOwnerOffset { get; set; } 

        [JsonPropertyName("isOwnerDir_")]
        public bool IsOwnerDir { get; set; } 

        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } 

        [JsonPropertyName("routeHomingAngle_")]
        public float RouteHomingAngle { get; set; } 

        [JsonPropertyName("goalDist_")]
        public float GoalDist { get; set; } 
    }
}

