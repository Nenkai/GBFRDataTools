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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.So6200;

[Obsolete("Not used by executable.")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class So6200LittleSnipperBlackRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So6200LittleSnipperBlackRushAction);

    [JsonPropertyName("scale_")]
    public Vector4 Scale { get; set; } = Vector4.UnitW;

    [JsonPropertyName("collisionRadius_")]
    public float CollisionRadius { get; set; } = 0.05f;

    [JsonPropertyName("collisionOffset_")]
    public Vector4 CollisionOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 10f;

    [JsonPropertyName("moveRate_")]
    public float MoveRate { get; set; } = 5f;

    [JsonPropertyName("rotateRate_")]
    [Obsolete("Not exposed by the executable")]
    public float RotateRate { get; set; }

    [JsonPropertyName("placeParams_")]
    public BindingList<PlaceParam> NearBreakRate { get; set; } = [];

    public class PlaceParam
    {
        [JsonPropertyName("startOffset_")]
        public Vector4 StartOffset { get; set; } = Vector4.UnitW;

        [JsonPropertyName("offset_")]
        public Vector4 Offset { get; set; }

        [JsonPropertyName("placeNum_")]
        public int PlaceNum { get; set; }
    }
}