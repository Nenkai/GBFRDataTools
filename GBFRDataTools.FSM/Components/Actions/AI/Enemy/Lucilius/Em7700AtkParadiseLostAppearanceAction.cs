using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkParadiseLostAppearanceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkParadiseLostAppearanceAction);

    [JsonPropertyName("startWaitShotTime_")]
    public float StartWaitShotTime { get; set; } = 0.01f; // Offset 0x70

    [JsonPropertyName("shotTime_")]
    public float ShotTime { get; set; } = 10f; // Offset 0x74

    [JsonPropertyName("oneShotWait_")]
    public float OneShotWait { get; set; } = 0.05f; // Offset 0x78

    [JsonPropertyName("hlType_")]
    public int HlType { get; set; } = 0; // Offset 0x7C
}
