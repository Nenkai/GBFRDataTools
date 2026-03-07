using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0100SlashComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0100SlashComboAction);

    [JsonPropertyName("atkCount_")]
    public int AtkCount { get; set; } = 3; // Offset 0x38

    [JsonPropertyName("motionIdNameFirst_")]
    public string MotionIdNameFirst { get; set; } // Offset 0x40

    [JsonPropertyName("motionIdNameSecond_")]
    public string MotionIdNameSecond { get; set; } // Offset 0x48

    [JsonPropertyName("motionIdNameThird_")]
    public string MotionIdNameThird { get; set; } // Offset 0x50

    [JsonPropertyName("rotRate_")]
    public float RotRate { get; set; } = 0.2f; // Offset 0x34

    public Em0100SlashComboAction()
    {
    }
}
