using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

#pragma warning disable IDE1006 // Naming Styles
public class isBootPhaseLanguageChanged : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(isBootPhaseLanguageChanged);
}
