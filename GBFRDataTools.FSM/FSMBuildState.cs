using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM;

public class FSMBuildState
{
    public Dictionary<int, List<FSMNode>> Layers { get; set; } = [];
}
