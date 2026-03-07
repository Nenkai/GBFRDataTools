using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0805CallOfDarknessAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0805CallOfDarknessAction);

    [JsonPropertyName("execMotionName_")]
    public string ExecMotionName { get; set; } // Offset 0x70

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 1f; // Offset 0x78

    [JsonPropertyName("bombModeSeName_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public string BombModeSeName { get; set; }

    public Em0805CallOfDarknessAction()
    {
    }
}
