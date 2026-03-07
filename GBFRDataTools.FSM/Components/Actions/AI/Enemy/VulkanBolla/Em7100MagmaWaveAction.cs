using GBFRDataTools.FSM.Components.Actions.AI.Enemy;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.VulkanBolla;

public class Em7100MagmaWaveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100MagmaWaveAction);

    [JsonPropertyName("isEscape_")]
    public bool IsEscape { get; set; } = true; // Offset 0x48

    [JsonPropertyName("isOdAbilityMagmaWave_")]
    public bool IsOdAbilityMagmaWave { get; set; } = false; // Offset 0x49

    [JsonPropertyName("isOdAbilityTalkEvent_")]
    public bool IsOdAbilityTalkEvent { get; set; } = false; // Offset 0x4A

    public Em7100MagmaWaveAction()
    {
    }
}

