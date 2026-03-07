using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700DempseyAction : Em1700CircleThunderAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700DempseyAction);

    [JsonPropertyName("loopNum_")]
    public int LoopNum { get; set; } = 2; // Offset 0xA8

    [JsonPropertyName("moveLengthMax_")]
    public float MoveLengthMax { get; set; } = 13f; // Offset 0xAC

    [JsonPropertyName("moveLengthMin_")]
    public float MoveLengthMin { get; set; } = 1.2f; // Offset 0xB0

    [JsonPropertyName("moveLengthOffset_")]
    public float MoveLengthOffset { get; set; } = -5f; // Offset 0xB4

    [JsonPropertyName("animRate_")]
    public float AnimRate { get; set; } = 1f; // Offset 0xB8

    [JsonPropertyName("tired_")]
    public bool Tired { get; set; } = false; // Offset 0xBC

    public Em1700DempseyAction()
    {
    }
}
