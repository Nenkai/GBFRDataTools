using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.VulkanBolla;

public class Em7100BreakDamageAction : EmDamageMotionPlayAction
{
    [JsonPropertyName("loopAnimId_")]
    public string LoopAnimId { get; set; }

    [JsonPropertyName("endAnimId_")]
    public string EndAnimId { get; set; }
}
