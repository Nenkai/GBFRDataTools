using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100SetVisibleWearSwordAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100SetVisibleWearSwordAction);

    [JsonPropertyName("visible_")]
    public bool Visible { get; set; } = true; // Offset 0x30

    public Em2100SetVisibleWearSwordAction()
    {
    }
}