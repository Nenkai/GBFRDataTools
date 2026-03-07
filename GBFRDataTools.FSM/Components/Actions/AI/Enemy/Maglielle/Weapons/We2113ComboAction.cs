using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2113ComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2113ComboAction);

    [JsonPropertyName("combo_")]
    public int Combo { get; set; } = 0; // Offset 0x34

    [JsonPropertyName("isAfterRushCombo_")]
    public bool IsAfterRushCombo { get; set; } = false; // Offset 0x38

    public We2113ComboAction()
    {
    }
}

