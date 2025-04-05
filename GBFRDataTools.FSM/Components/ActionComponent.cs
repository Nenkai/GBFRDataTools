using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components;

// BT::QuestActionComponent
public class ActionComponent : BehaviorTreeComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ActionComponent);

    public override string ToString()
    {
        return ComponentName;
    }
}
