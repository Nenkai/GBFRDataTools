using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

// BTInGame::Transition
public class Transition
{
    // Did they mix up to and from? from is always as the target node.
    public int ToNodeGuid { get; set; } // exposed as toNodeGuid_
    public int FromNodeGuid { get; set; } // exposed as fromNodeGuid_
    public List<int> ConditionGuids { get; set; } = new List<int>(); // exposed as conditionGuids_
    public List<BehaviorTreeComponent> ConditionComponents { get; set; } = new List<BehaviorTreeComponent>();

    public Transition(int toNodeGuid, int fromNodeGuid)
    {
        ToNodeGuid = toNodeGuid;
        FromNodeGuid = fromNodeGuid;
    }

    // Emulation
    public bool Execute(int unk)
    {
        return true;
    }
}