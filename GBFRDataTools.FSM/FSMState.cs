using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM;

public class FSMState
{
    public Dictionary<int, List<FSMNode>> Layers { get; set; } = [];
    public FsmEditorSettings EditorSettings { get; set; } = new();
}
