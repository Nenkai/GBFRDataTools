using GBFRDataTools.FSM.Components.Actions.Motion;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7200BackKickAction : MotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200BackKickAction);

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 3f; // Offset 0x90

    public Em7200BackKickAction()
    {
    }
}
