using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005SlashShotAction : Em0005BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005SlashShotAction);

    [JsonPropertyName("comboType_")]
    public int ComboType { get; set; } = 0; // Offset 0x3C

    public Em0005SlashShotAction()
    {
    }
}


