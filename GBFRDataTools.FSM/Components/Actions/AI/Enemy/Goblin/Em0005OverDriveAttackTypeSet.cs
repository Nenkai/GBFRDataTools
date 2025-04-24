using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005OverDriveAttackTypeSet : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005OverDriveAttackTypeSet);

    [JsonPropertyName("valueMin_")]
    public int ValueMin { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("valueMax_")]
    public int ValueMax { get; set; } = 0; // Offset 0x34

    public Em0005OverDriveAttackTypeSet()
    {
    }
}
