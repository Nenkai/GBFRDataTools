using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetIslandMaskImage : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetIslandMaskImage);

    public SetIslandMaskImage()
    {
    }
}
