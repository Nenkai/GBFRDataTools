using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Vrazarek;

public class Em1801MeleeBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801MeleeBreathAction);

    [JsonPropertyName("magmaMoveSec_")]
    public float MagmaMoveSec { get; set; } = 2f; // Offset 0xB0

    public Em1801MeleeBreathAction()
    {
    }
}
