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
public class Em8300AtkOverDriveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkOverDriveAction);

    [JsonPropertyName("warpPunchOffsetPos_")]
    public Vector4 WarpPunchOffsetPos { get; set; } = new Vector4(0f, 0f, -6f, 1f);

    [JsonPropertyName("warpBeamOffsetPos_")]
    public Vector4 WarpBeamOffsetPos { get; set; } = new Vector4(0f, 6f, 26f, 1f);

    [JsonPropertyName("warpFallPunchOffsetPos_")]
    public Vector4 WarpFallPunchOffsetPos { get; set; } = new Vector4(0f, 6f, 0f, 1f);

    [JsonPropertyName("warpWaitTime_")]
    public float WarpWaitTime { get; set; } = 1f;

    [JsonPropertyName("beamWarpWaitTime_")]
    public float BeamWarpWaitTime { get; set; } = 0.5f;

    [JsonPropertyName("punchWarpWaitTime_")]
    public float PunchWarpWaitTime { get; set; } = 0f;

    [JsonPropertyName("beamMoveTime_")]
    public float BeamMoveTime { get; set; } = 3f;

    [JsonPropertyName("beamLineTime_")]
    public float BeamLineTime { get; set; } = 3f;

    [JsonPropertyName("punchCountMax_")]
    public int PunchCountMax { get; set; } = 2;

    [JsonPropertyName("punchShockAttackCountMax_")]
    public int PunchShockAttackCountMax { get; set; } = 8;

    [JsonPropertyName("punchShockTime_")]
    public float PunchShockTime { get; set; } = 0.2f;

    [JsonPropertyName("beamOffsetZ_")]
    public float BeamOffsetZ { get; set; } = 23.8f;

    [JsonPropertyName("beamOffsetY_")]
    public float BeamOffsetY { get; set; } = 8.8f;

    [JsonPropertyName("fallPunchTime_")]
    public float FallPunchTime { get; set; } = 0.2f;

    [JsonPropertyName("playerAttackTime_")]
    public float PlayerAttackTime { get; set; } = 0.4f;

    [JsonPropertyName("playerAttackTimeWingMode_")]
    public float PlayerAttackTimeWingMode { get; set; } = 0.4f;

    [JsonPropertyName("fallPunchCrackNum_")]
    public int FallPunchCrackNum { get; set; } = 5;

    [JsonPropertyName("fallPunchAttackRandomX_")]
    public float FallPunchAttackRandomX { get; set; } = 10f;

    [JsonPropertyName("fallPunchAttackRandomMaxZ_")]
    public float FallPunchAttackRandomMaxZ { get; set; } = 25f;

    [JsonPropertyName("fallPunchAttackRandomMinZ_")]
    public float FallPunchAttackRandomMinZ { get; set; } = 7f;

    [JsonPropertyName("fallPunchAttackRandomAddZ_")]
    public float FallPunchAttackRandomAddZ { get; set; } = 9f;

    [JsonPropertyName("smallBeamWaitTime_")]
    public float SmallBeamWaitTime { get; set; } = 6f;

    [JsonPropertyName("smallBeamWaitTimeWingMode_")]
    public float SmallBeamWaitTimeWingMode { get; set; } = 6f;

    [JsonPropertyName("playerRandomAttackTime_")]
    public float PlayerRandomAttackTime { get; set; } = 1f;

    [JsonPropertyName("playerRandomAttackDelayTime_")]
    public float PlayerRandomAttackDelayTime { get; set; } = 0.5f;

    [JsonPropertyName("otherRandomAttackNum_")]
    public int OtherRandomAttackNum { get; set; } = 3;

    [JsonPropertyName("otherRandomAttackLngthMax_")]
    public float OtherRandomAttackLngthMax { get; set; } = 22f;

    [JsonPropertyName("otherRandomAttackLngthMin_")]
    public float OtherRandomAttackLngthMin { get; set; } = 7f;

    [JsonPropertyName("otherRandomlength_")]
    public float OtherRandomlength { get; set; } = 0.5f;

    [JsonPropertyName("otherRandomAngle_")]
    public float OtherRandomAngle { get; set; } = 0.31415927f;

    [JsonPropertyName("visibleLength_")]
    public float VisibleLength { get; set; } = 5f;

    [JsonPropertyName("places_")]
    public BindingList<Em8300AtkOverDriveActionBeamLinePlace> Places { get; set; } = []; // std::vector<BT::Em8300AtkOverDriveAction::Em8300AtkOverDriveActionBeamLinePlace>

    public class Em8300AtkOverDriveActionBeamLinePlace /* Em8300AtkOverDriveAction::Em8300AtkOverDriveActionBeamLinePlace */
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }
    
        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }
    
        [JsonPropertyName("time_")]
        public float Time { get; set; }
    
        [JsonPropertyName("waitTime_")]
        public float WaitTime { get; set; }
    }
}