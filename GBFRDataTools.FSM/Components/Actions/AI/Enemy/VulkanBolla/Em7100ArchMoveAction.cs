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

public class Em7100ArchMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100ArchMoveAction);

    [JsonPropertyName("isMoveLeft_")]
    public bool IsMoveLeft { get; set; } = true; // Offset 0x30

    [JsonPropertyName("isContinuousMove_")]
    public bool IsContinuousMove { get; set; } = false; // Offset 0x31

    [JsonPropertyName("isSetSurfacePos_")]
    public bool IsSetSurfacePos { get; set; } = false; // Offset 0x32

    public Em7100ArchMoveAction()
    {
    }
}
