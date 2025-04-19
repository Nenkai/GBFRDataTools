using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Save;

public class SaveSuccess : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SaveSuccess);

    public SaveSuccess()
    {
    }
}
