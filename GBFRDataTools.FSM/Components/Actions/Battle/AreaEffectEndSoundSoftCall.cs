using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectEndSoundSoftCall : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AreaEffectEndSoundSoftCall);

    [JsonPropertyName("softCallWorkIndex_")]
    public int SoftCallWorkIndex { get; set; }
}