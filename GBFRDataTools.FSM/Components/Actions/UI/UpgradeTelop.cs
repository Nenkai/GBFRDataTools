using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class UpgradeTelop : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(UpgradeTelop);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0; // Offset 0x30

    public UpgradeTelop()
    {
    }
}
