using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600OverDriveSpecial1MoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600OverDriveSpecial1MoveAction);

    [JsonPropertyName("places_")]
    public BindingList<Em7600OverDriveSpecial1MovePlace> Places { get; set; } = [new Em7600OverDriveSpecial1MovePlace()];

    [JsonPropertyName("randMoveValue_")]
    public float RandMoveValue { get; set; } = 5.0f;

    [JsonPropertyName("timeRate_")]
    public float TimeRate { get; set; } = 1.0f;

    [JsonPropertyName("widthRate_")]
    public float WidthRate { get; set; } = 1.0f;

    [JsonPropertyName("SpeedRate_")]
    public float SpeedRate { get; set; } = 1.0f;

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 5.0f;

    [JsonPropertyName("isChaosMove_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsChaosMove { get; set; } = false;

    [JsonPropertyName("chaosWidthRate_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ChaosWidthRate { get; set; } = 5f;

    [JsonPropertyName("chaosChangeTime1_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ChaosChangeTime1 { get; set; } = 3f;

    [JsonPropertyName("chaosChangeTime2_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ChaosChangeTime2 { get; set; } = 3f;

    [JsonPropertyName("chaosChangeTime3_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ChaosChangeTime3 { get; set; } = 4f;

    [JsonPropertyName("chaosRotSpeedMax_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ChaosRotSpeedMax { get; set; } = 5f;

    [JsonPropertyName("speedMaxTime_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float SpeedMaxTime { get; set; } = 2.25f;

    [JsonPropertyName("chaosSpeedRate_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ChaosSpeedRate { get; set; } = 5f;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Em7600OverDriveSpecial1MovePlace // BT::Em7600OverDriveSpecial1MoveAction::Em7600OverDriveSpecial1MovePlace
    {
        [JsonPropertyName("pos_")]
        public /* cVec4 */ Vector4 Pos { get; set; } = Vector4.UnitW;

        [JsonPropertyName("time_")]
        public float Time { get; set; } = 5.0f;
    }
}
