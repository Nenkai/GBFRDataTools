using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001SummonAttributeAction : Em7001SummonCoreBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001SummonAttributeAction);

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; } // Offset 0x70

    [JsonPropertyName("isBuff_")]
    public bool IsBuff { get; set; } = false; // Offset 0x94

    public Em7001SummonAttributeAction()
    {
    }
}
