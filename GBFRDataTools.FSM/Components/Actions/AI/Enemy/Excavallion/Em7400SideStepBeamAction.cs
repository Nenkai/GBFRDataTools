using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Excavallion;

public class Em7400SideStepBeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7400SideStepBeamAction);

    [JsonPropertyName("isMoveRight_")]
    public bool IsMoveRight { get; set; } = true; // Offset 0x3C

    public Em7400SideStepBeamAction()
    {
    }
}
