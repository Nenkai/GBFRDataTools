using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2104MeleeSwordThrowAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2104MeleeSwordThrowAction);

    [JsonPropertyName("throwType_")]
    public int ThrowType { get; set; } = 0; // Offset 0x34

    public We2104MeleeSwordThrowAction()
    {
    }
}

