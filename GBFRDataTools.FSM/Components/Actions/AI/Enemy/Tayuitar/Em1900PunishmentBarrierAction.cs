using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900PunishmentBarrierAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900PunishmentBarrierAction);

    [JsonPropertyName("fragmentNum_")]
    public int FragmentNum { get; set; } = 10; // Offset 0x38

    [JsonPropertyName("isSuper_")]
    public bool IsSuper { get; set; } = false; // Offset 0x3C

    public Em1900PunishmentBarrierAction()
    {
    }
}


