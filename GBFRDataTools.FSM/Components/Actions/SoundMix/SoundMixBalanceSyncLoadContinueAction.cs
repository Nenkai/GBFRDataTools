using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.SoundMix;

public class SoundMixBalanceSyncLoadContinueAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundMixBalanceSyncLoadContinueAction);
}
