using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;
using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Wilinus;

public class Em1802RapidIceBallAction : Em1800RapidFireBallAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802RapidIceBallAction);

    [JsonPropertyName("isChangeSecondShot_")]
    public bool IsChangeSecondShot { get; set; } = false; // Offset 0x40

    public Em1802RapidIceBallAction()
    {
    }
}
