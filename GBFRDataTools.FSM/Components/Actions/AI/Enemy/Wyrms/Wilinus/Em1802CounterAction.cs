using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Wilinus;

public class Em1802CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802CounterAction);

    [JsonPropertyName("iceGravelNum_")]
    public int IceGravelNum { get; set; } = 36; // Offset 0x70

    [JsonPropertyName("angleDivisionNum_")]
    public int AngleDivisionNum { get; set; } = 6; // Offset 0x74

    [JsonPropertyName("startMaxDis_")]
    public float StartMaxDis { get; set; } = 11.5f; // Offset 0x78

    [JsonPropertyName("startMinDis_")]
    public float StartMinDis { get; set; } = 7f; // Offset 0x7C

    [JsonPropertyName("maxLength_")]
    public float MaxLength { get; set; } = 20f; // Offset 0x80

    [JsonPropertyName("minLength_")]
    public float MinLength { get; set; } = 10f; // Offset 0x84

    [JsonPropertyName("toPlayerGravelMaxDis")]
    public float ToPlayerGravelMaxDis { get; set; } = 7f; // Offset 0x88

    [JsonPropertyName("toPlayerGravelMinDis")]
    public float ToPlayerGravelMinDis { get; set; } = 5f; // Offset 0x8C

    public Em1802CounterAction()
    {
    }
}
