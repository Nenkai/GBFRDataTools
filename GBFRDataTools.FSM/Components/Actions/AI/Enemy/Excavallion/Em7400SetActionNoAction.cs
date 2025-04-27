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

public class Em7400SetActionNoAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7400SetActionNoAction);

    [JsonPropertyName("actionNo_")]
    public int ActionNo { get; set; } = 0; // Offset 0x30

    public Em7400SetActionNoAction()
    {
    }
}
