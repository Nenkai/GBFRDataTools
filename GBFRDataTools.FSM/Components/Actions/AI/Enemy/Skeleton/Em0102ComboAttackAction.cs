using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Skeleton;

public class Em0102ComboAttackAction : AreaEffectAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0102ComboAttackAction);

    [JsonPropertyName("comboIndex_")]
    public int ComboIndex { get; set; } = 0;

    [JsonPropertyName("motionStartFrame_")]
    public int MotionStartFrame { get; set; } = 0;
}
