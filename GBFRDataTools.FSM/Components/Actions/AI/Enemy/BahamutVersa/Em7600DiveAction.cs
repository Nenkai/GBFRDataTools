using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600DiveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600DiveAction);

    [JsonPropertyName("phase1Frame_")]
    public int Phase1Frame { get; set; } = 200; // Offset 0x34

    [JsonPropertyName("phase2Frame_")]
    public int Phase2Frame { get; set; } = 270; // Offset 0x38

    [JsonPropertyName("phase3Frame_")]
    public int Phase3Frame { get; set; } = 315; // Offset 0x3C

    [JsonPropertyName("phase4Frame_")]
    public int Phase4Frame { get; set; } = 345; // Offset 0x40

    [JsonPropertyName("phase5Frame_")]
    public int Phase5Frame { get; set; } = 385; // Offset 0x44

    [JsonPropertyName("phase6Frame_")]
    public int Phase6Frame { get; set; } = 415; // Offset 0x48

    public Em7600DiveAction()
    {
    }
}
