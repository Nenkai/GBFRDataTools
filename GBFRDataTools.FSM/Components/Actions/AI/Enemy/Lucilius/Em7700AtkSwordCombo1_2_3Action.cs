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

public class Em7700AtkSwordCombo1_2_3Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkSwordCombo1_2_3Action);

    [JsonPropertyName("isForceNextCombo_")]
    public bool IsForceNextCombo { get; set; } = false; // Offset 0x70

    [JsonPropertyName("isTypeB_")]
    public bool IsTypeB { get; set; } = false; // Offset 0x71

    [JsonPropertyName("isUseShot_")]
    public bool IsUseShot { get; set; } = false; // Offset 0x72

    public Em7700AtkSwordCombo1_2_3Action()
    {
    }
}


