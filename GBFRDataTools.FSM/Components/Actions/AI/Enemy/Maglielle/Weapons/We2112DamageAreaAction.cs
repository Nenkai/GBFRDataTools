using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2112DamageAreaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2112DamageAreaAction);

    [JsonPropertyName("damageAreaType_")]
    public int DamageAreaType { get; set; } = 0; // Offset 0x40

    [JsonPropertyName("damageIndex_")]
    public int DamageIndex { get; set; } = 0; // Offset 0x44

    public We2112DamageAreaAction()
    {
    }
}

