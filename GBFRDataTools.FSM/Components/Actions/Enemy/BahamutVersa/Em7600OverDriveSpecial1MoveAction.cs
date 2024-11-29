using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.BahamutVersa;

public class Em7600OverDriveSpecial1MoveAction : ActionComponent
{
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

    public class Em7600OverDriveSpecial1MovePlace // BT::Em7600OverDriveSpecial1MoveAction::Em7600OverDriveSpecial1MovePlace
    {
        [JsonPropertyName("pos_")]
        public /* cVec4 */ Vector4 Pos { get; set; } = Vector4.UnitW;

        [JsonPropertyName("time_")]
        public float Time { get; set; } = 5.0f;
    }
}
