using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Evyl;

public class Em1806SummonSeedAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1806SummonSeedAction);

    [JsonPropertyName("bombSeedSummonNum_")]
    public int BombSeedSummonNum { get; set; } = 1; // Offset 0x40

    public Em1806SummonSeedAction()
    {
    }
}