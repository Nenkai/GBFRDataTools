using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkOverDriveLineAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkOverDriveLineAction);

    [JsonPropertyName("beamLineIndex_")]
    public int BeamLineIndex { get; set; } = 0;

    [JsonPropertyName("isLineEnd_")]
    public bool IsLineEnd { get; set; } = false;

    [JsonPropertyName("places_")]
    public BindingList<Em8300AtkOverDriveLinePlace> Places { get; set; } = [];

    public class Em8300AtkOverDriveLinePlace /* Em8300AtkOverDriveLineAction::Em8300AtkOverDriveLinePlace */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; } // Offset 0x20
    
        [JsonPropertyName("time_")]
        public float Time { get; set; } // Offset 0x30
    
        [JsonPropertyName("waitTime_")]
        public float WaitTime { get; set; } // Offset 0x34
    
        [JsonPropertyName("scaleZ_")]
        public float ScaleZ { get; set; } // Offset 0x38
    
        [JsonPropertyName("scaleChangeTime_")]
        public float ScaleChangeTime { get; set; }
    }
}