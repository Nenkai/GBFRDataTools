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

public class Em7100ObjHitFlagAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7100ObjHitFlagAction);

    [JsonPropertyName("objHitOffFlag_")]
    public uint ObjHitOffFlag { get; set; } = 0; // Offset 0x30

    public Em7100ObjHitFlagAction()
    {
    }
}
