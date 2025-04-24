using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class EmCultSoldierBaseDamageReactionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmCultSoldierBaseDamageReactionAction);

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 3; // Offset 0x30

    public EmCultSoldierBaseDamageReactionAction()
    {
    }
}