using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1002VisibleArrowAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1002VisibleArrowAction);

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0; // Offset 0x34

    [JsonPropertyName("setFlag_")]
    public bool SetFlag { get; set; } = true; // Offset 0x30

    public Em1002VisibleArrowAction()
    {
    }
}