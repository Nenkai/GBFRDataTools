using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520SpecialArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520SpecialArtsAction);

    [JsonPropertyName("chargeBallShotWait_")]
    public float ChargeBallShotWait { get; set; } = 0.5f; // Offset 0x120

    public Em7520SpecialArtsAction()
    {
    }
}


