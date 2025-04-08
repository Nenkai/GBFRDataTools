using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Sound;

public class SoundBankLoadCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundBankLoadCondition);
}
