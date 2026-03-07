using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkParadiseLostOffsetCutinAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkParadiseLostOffsetCutinAction);

    [JsonPropertyName("canSkipCutin_")]
    public bool CanSkipCutin { get; set; } = false; // Offset 0x70

    public Em7700AtkParadiseLostOffsetCutinAction()
    {
    }
}


