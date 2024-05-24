using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

// BT::QuestActionComponent
public class ActionComponent : BehaviorTreeComponent
{
    public override string ToString()
    {
        return ComponentName;
    }
}
