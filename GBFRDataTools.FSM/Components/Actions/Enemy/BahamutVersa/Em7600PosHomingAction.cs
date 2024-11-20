using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.BahamutVersa;

public class Em7600PosHomingAction : ActionComponent
{
    [JsonPropertyName("em7600PosHomings_")]
    public BindingList<Em7600PosHoming> Em7600PosHomings { get; set; }

    public class Em7600PosHoming // Em7600PosHomingAction::Em7600PosHoming
    {
        [JsonPropertyName("homingSpeed_")]
        public float HomingSpeed { get; set; }

        [JsonPropertyName("startFrame_")]
        public int StartFrame { get; set; }

        [JsonPropertyName("endFrame_")]
        public int EndFrame { get; set; }

        [JsonPropertyName("offsetTargetPos_")]
        public cVec4 OffsetTargetPos { get; set; }

        [JsonPropertyName("useOrigin_")]
        public bool UseOrigin { get; set; }
    }
}


