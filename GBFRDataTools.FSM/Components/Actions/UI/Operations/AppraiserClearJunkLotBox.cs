using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Operations;

public class AppraiserClearJunkLotBox : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AppraiserClearJunkLotBox);
}
