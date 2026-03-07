using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2105ShotSpArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2105ShotSpArtsAction);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0; // Offset 0x238

    public We2105ShotSpArtsAction()
    {
    }
}

