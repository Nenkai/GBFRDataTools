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
public class Em8300AtkOverDriveBeamMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkOverDriveBeamMoveAction);

    [JsonPropertyName("beamLineIndex_")]
    public int BeamLineIndex { get; set; } = 0;

    [JsonPropertyName("places_")]
    public BindingList<Em8300AtkOverDriveLinePlace> Places { get; set; } = [];

    [JsonPropertyName("beamWaitTime_")]
    public float BeamWaitTime { get; set; } = 1.5f;

    [JsonPropertyName("smallBeamWaitTime_")]
    public float SmallBeamWaitTime { get; set; } = 1.5f;

    [JsonPropertyName("offsetRotY_")]
    public float OffsetRotY { get; set; } = 0f;

    [JsonPropertyName("isSmallBeam_")]
    public bool IsSmallBeam { get; set; } = true;

    [JsonPropertyName("isSetPlayerAITarget_")]
    public bool IsSetPlayerAITarget { get; set; } = false;

    [JsonPropertyName("isSetPlayerAI1stPlace_")]
    public bool IsSetPlayerAI1stPlace { get; set; } = false;

    [JsonPropertyName("playerAIMovePos1st_")]
    public BindingList<Vector4> PlayerAIMovePos1st { get; set; } = [.. Enumerable.Repeat(Vector4.Zero, 3)]; // std::array<Hw::cVec4,3>

    public class Em8300AtkOverDriveLinePlace /* Em8300AtkOverDriveBeamMoveAction::Em8300AtkOverDriveLinePlace */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }
    
        [JsonPropertyName("time_")]
        public float Time { get; set; }
    
        [JsonPropertyName("waitTime_")]
        public float WaitTime { get; set; }
    
        [JsonPropertyName("scaleZ_")]
        public float ScaleZ { get; set; }
    
        [JsonPropertyName("playerAIMovePos_")]
        public BindingList<Vector4> PlayerAIMovePos { get; set; } = [.. Enumerable.Repeat(Vector4.Zero, 3)]; // std::array<Hw::cVec4,3>
    }
}