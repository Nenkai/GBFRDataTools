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
    public float HomingAngle { get; set; } = 0.5f; // Offset 0x88

    [JsonPropertyName("moveRate_")]
    public float MoveRate { get; set; } = 1f; // Offset 0x8C

    [JsonPropertyName("wallDegX_")]
    public float WallDegX { get; set; } = 60f; // Offset 0x98

    [JsonPropertyName("isCheckTarget_")]
    public bool IsCheckTarget { get; set; } = false; // Offset 0x9C

    [JsonPropertyName("checkNearTargetLength_")]
    public float CheckNearTargetLength { get; set; } = 0f; // Offset 0xA0

    [JsonPropertyName("isRouteMove_")]
    public bool IsRouteMove { get; set; } = false; // Offset 0xA4

    [JsonPropertyName("isAppearAgain_")]
    public bool IsAppearAgain { get; set; } = false; // Offset 0xA5

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 10f; // Offset 0x90

    [JsonPropertyName("wallHitMoveSecRate_")]
    public float WallHitMoveSecRate { get; set; } = 5f; // Offset 0x94

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; // Offset 0xA8

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; // Offset 0xAC

    [JsonPropertyName("moveTargetType_")]
    public int MoveTargetType { get; set; } = 0; // Offset 0xB0

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; } = 102; // Offset 0xB4

    [JsonPropertyName("routeParams_")]
    public BindingList<RouteParam> RouteParams { get; set; } = []; // Offset 0xB8

    public Em2600MoveToAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class RouteParam
    {
        [JsonPropertyName("isOwnerOffset_")]
        public bool IsOwnerOffset { get; set; } // Offset 0x10

        [JsonPropertyName("isOwnerDir_")]
        public bool IsOwnerDir { get; set; } // Offset 0x11

        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x20

        [JsonPropertyName("routeHomingAngle_")]
        public float RouteHomingAngle { get; set; } // Offset 0x30

        [JsonPropertyName("goalDist_")]
        public float GoalDist { get; set; } // Offset 0x34

        public RouteParam()
        {
        }
    }
}

