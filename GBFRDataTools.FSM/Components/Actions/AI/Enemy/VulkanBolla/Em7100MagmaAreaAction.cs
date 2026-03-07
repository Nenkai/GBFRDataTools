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

public class Em7100MagmaAreaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100MagmaAreaAction);

    [JsonPropertyName("dir_")]
    public int Dir { get; set; } = 0; // Offset 0x40

    public Em7100MagmaAreaAction()
    {
    }
}

