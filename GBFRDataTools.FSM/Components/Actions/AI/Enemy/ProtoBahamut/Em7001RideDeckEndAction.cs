using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001RideDeckEndAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001RideDeckEndAction);

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; // Offset 0x60

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; } // Offset 0x68

    public Em7001RideDeckEndAction()
    {
    }
}

