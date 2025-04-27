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

public class Em7100BuffAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100BuffAction);

    [JsonPropertyName("isUseCameraAnim_")]
    public bool IsUseCameraAnim { get; set; } = false; // Offset 0x30

    public Em7100BuffAction()
    {
    }
}

