using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.BahamutVersa;

public class Em7600OverDriveSpecial1MoveAction : ActionComponent
{
    [JsonPropertyName("places_")]
    public BindingList<Em7600OverDriveSpecial1MovePlace> Places { get; set; }

    [JsonPropertyName("randMoveValue_")]
    public float RandMoveValue { get; set; }

    [JsonPropertyName("timeRate_")]
    public float TimeRate { get; set; }

    [JsonPropertyName("widthRate_")]
    public float WidthRate { get; set; }

    [JsonPropertyName("SpeedRate_")]
    public float SpeedRate { get; set; }

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; }

    public class Em7600OverDriveSpecial1MovePlace // BT::Em7600OverDriveSpecial1MoveAction::Em7600OverDriveSpecial1MovePlace
    {
        [JsonPropertyName("pos_")]
        public cVec4 Pos { get; set; }

        [JsonPropertyName("time_")]
        public float Time { get; set; }
    }
}
