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

    /// <summary>
    /// to = FROM aka SOURCE NODE, it's reversed
    /// </summary>
    public int ToNodeGuid { get; set; } // exposed as toNodeGuid_

    /// <summary>
    /// From = TO aka TARGET NODE, it's reversed
    /// </summary>
    public int FromNodeGuid { get; set; } // exposed as fromNodeGuid_

    public List<int> ConditionGuids { get; set; } = []; // exposed as conditionGuids_
    public List<ConditionComponent> ConditionComponents { get; set; } = [];

    /// <summary>
    /// Marks the transition as pointing to a node that ends the layer (or FSM?) <br/>
    /// Node is not physically present in the FSM file, but implied to exist at least.
    /// </summary>
    public bool IsEndTransition { get; set; } // exposed as "isEndTransition_"


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