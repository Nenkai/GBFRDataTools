using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0103ComboAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0103ComboAttackAction);

    [JsonPropertyName("comboIndex_")]
    public int ComboIndex { get; set; } = 0;

    [JsonPropertyName("motionStartFrame_")]
    public int MotionStartFrame { get; set; } = 0;
}
