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

public class Em7100MagmaWaveDiveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100MagmaWaveDiveAction);

    [JsonPropertyName("isResetSurfacePosIndices_")]
    public bool IsResetSurfacePosIndices { get; set; } = false; // Offset 0x5C

    [JsonPropertyName("isNotifyDestPos_")]
    public bool IsNotifyDestPos { get; set; } = false; // Offset 0x5D

    public Em7100MagmaWaveDiveAction()
    {
    }
}
