using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900OverDriveRushBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900OverDriveRushBaseAction);

    [JsonPropertyName("isFirst_")]
    public bool IsFirst { get; set; } = false; // Offset 0xAC

    [JsonPropertyName("isFinish_")]
    public bool IsFinish { get; set; } = false; // Offset 0xAD

    [JsonPropertyName("nextWeaponType_")]
    public int NextWeaponType { get; set; } = 0; // Offset 0xB0

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0f; // Offset 0xB4

    [JsonPropertyName("homingRateStop_")]
    public float HomingRateStop { get; set; } = 0.1f; // Offset 0xB8

    [JsonPropertyName("dushTime_")]
    public float DushTime { get; set; } = 2f; // Offset 0xBC

    [JsonPropertyName("intervalShotFrameNum_")]
    public int IntervalShotFrameNum { get; set; } = 1; // Offset 0x70

    [JsonPropertyName("homingBeamRate_")]
    public float HomingBeamRate { get; set; } = 0f; // Offset 0xC0

    [JsonPropertyName("isEnableBeam_")]
    public bool IsEnableBeam { get; set; } = true; // Offset 0xC4

    public Em1900OverDriveRushBaseAction()
    {
    }
}

