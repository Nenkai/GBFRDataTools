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

public class Em7400BlowAwaySignAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7400BlowAwaySignAction);

    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; } = 0f; // Offset 0x40

    [JsonPropertyName("blowSignWaitSecR_")]
    public float BlowSignWaitSecR { get; set; } = 0f; // Offset 0x44

    [JsonPropertyName("blowSignWaitSecL_")]
    public float BlowSignWaitSecL { get; set; } = 0f; // Offset 0x48

    public Em7400BlowAwaySignAction()
    {
    }
}
