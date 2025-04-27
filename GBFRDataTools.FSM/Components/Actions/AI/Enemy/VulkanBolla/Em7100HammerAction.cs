using GBFRDataTools.FSM.Components.Actions.AI.Enemy;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.VulkanBolla;

public class Em7100FireWallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100FireWallAction);

    [JsonPropertyName("isOdAbilityMode_")]
    public bool IsOdAbilityMode { get; set; } = false; // Offset 0x48

    public Em7100FireWallAction()
    {
    }
}

