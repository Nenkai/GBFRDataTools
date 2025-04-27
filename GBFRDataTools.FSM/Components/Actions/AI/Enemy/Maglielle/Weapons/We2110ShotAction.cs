using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2110ShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2110ShotAction);

    [JsonPropertyName("shotType_")]
    public int ShotType { get; set; } = 0; // Offset 0x60

    public We2110ShotAction()
    {
    }
}

