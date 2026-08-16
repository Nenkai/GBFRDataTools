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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.BallisticBallista;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So4200MachineGunAndLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So4200MachineGunAndLaserAction);

    [JsonPropertyName("machineGunInterval_")]
    public float MachineGunInterval { get; set; } = 5f;

    [JsonPropertyName("machineGunDispersion_")]
    public float MachineGunDispersion { get; set; } = 0.2f;

    [JsonPropertyName("laserAtkRate_")]
    public float LaserAtkRate { get; set; } = 3f;

    [JsonPropertyName("laserTriggerHitCount_")]
    public int LaserTriggerHitCount { get; set; } = 10;

    [JsonPropertyName("hitCountResetTime_")]
    public float HitCountResetTime { get; set; } = 3f;

    [JsonPropertyName("laserAtkCoolDownTime_")]
    public float LaserAtkCoolDownTime { get; set; } = 0.5f;

    [JsonPropertyName("targetPosBbKey_")]
    public string TargetPosBbKey { get; set; }

    [JsonPropertyName("machineGunCreateNumMax_")]
    public BindingList<int> MachineGunCreateNumMax { get; set; } = [..Enumerable.Repeat(0, 3)]; // std::array<int,3>
}
