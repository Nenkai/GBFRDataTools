using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0002MotionPlayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0002MotionPlayAction);

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; } // Offset 0x30

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.05f; // Offset 0x38

    public Em0002MotionPlayAction()
    {
    }
}
