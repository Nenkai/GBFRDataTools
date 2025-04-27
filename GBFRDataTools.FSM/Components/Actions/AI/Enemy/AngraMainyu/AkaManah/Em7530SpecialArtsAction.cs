using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.AkaManah;

public class Em7530SpecialArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7530SpecialArtsAction);

    [JsonPropertyName("chargeBallShotWait_")]
    public float ChargeBallShotWait { get; set; } = 0.5f; // Offset 0x70

    [JsonPropertyName("laserWaitTime_")]
    public float LaserWaitTime { get; set; } = 9f; // Offset 0x74

    public Em7530SpecialArtsAction()
    {
    }
}