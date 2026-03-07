using GBFRDataTools.FSM.Components.Actions.Motion;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005ComboMotionPlayAction : ComboMotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005ComboMotionPlayAction);

    [JsonPropertyName("checkContinueTime_")]
    public float CheckContinueTime { get; set; } = 0f; // Offset 0xD8

    public Em0005ComboMotionPlayAction()
    {
    }
}

