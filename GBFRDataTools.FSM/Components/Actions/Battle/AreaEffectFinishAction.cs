using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

// typo is their mistake (uppercase I in Finish)
public class AreaEffectFInishAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AreaEffectFInishAction);
}
