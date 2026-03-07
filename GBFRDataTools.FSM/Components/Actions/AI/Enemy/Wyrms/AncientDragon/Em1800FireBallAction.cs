using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800FireBallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800FireBallAction);

    [JsonPropertyName("isAttackCancel_")]
    public bool IsAttackCancel { get; set; } = false; // Offset 0x38

    [JsonPropertyName("blendMotionRateSpeed_")]
    public float BlendMotionRateSpeed { get; set; } = 0f; // Offset 0x3C

    public Em1800FireBallAction()
    {
    }
}
