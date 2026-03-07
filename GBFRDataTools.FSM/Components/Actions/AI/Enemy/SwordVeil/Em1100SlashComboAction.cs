using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SwordVeil;

public class Em1100SlashComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1100SlashComboAction);

    [JsonPropertyName("comboMotIds_")]
    public BindingList<string> ComboMotIds { get; set; } = []; // Offset 0x38

    public Em1100SlashComboAction()
    {
    }
}