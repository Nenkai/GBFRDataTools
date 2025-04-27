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

public class Em7600VFXAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600VFXAction);

    [JsonPropertyName("id_")]
    public int Id { get; set; } = 0; // Offset 0x50

    [JsonPropertyName("startFrame_")]
    public int StartFrame { get; set; } = 0; // Offset 0x54

    [JsonPropertyName("vanishFrame_")]
    public int VanishFrame { get; set; } = 0; // Offset 0x58

    [JsonPropertyName("isOwner_")]
    public bool IsOwner { get; set; } = true; // Offset 0x5E

    public Em7600VFXAction()
    {
    }
}
