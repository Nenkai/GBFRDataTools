using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.BehaviorTree;

public class CompositeNode : TreeNode
{
    public List<TreeNode> Children { get; set; } = [];
}
