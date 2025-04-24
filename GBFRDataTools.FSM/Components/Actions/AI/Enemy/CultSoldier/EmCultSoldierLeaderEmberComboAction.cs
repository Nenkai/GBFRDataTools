using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1004GroupComboAction : Em1003GroupComboAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1004GroupComboAction);

    [JsonPropertyName("comboIndex_")]
    public int ComboIndex { get; set; } = 0; // Offset 0xB0

    public Em1004GroupComboAction()
    {
    }
}