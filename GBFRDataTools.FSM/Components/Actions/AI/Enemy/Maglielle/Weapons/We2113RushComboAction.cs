using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2113RushComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2113RushComboAction);

    [JsonPropertyName("isUsePurposeFlagToCancel_")]
    public bool IsUsePurposeFlagToCancel { get; set; } = false; // Offset 0x44

    public We2113RushComboAction()
    {
    }
}

