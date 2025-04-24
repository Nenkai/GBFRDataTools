using GBFRDataTools.FSM.Components.Actions.BlackBoard;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wolf;

public class Em0200RegisterShareRiderBlackBoardIntAction : RegisterBlackBoardIntAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200RegisterShareRiderBlackBoardIntAction);

    public Em0200RegisterShareRiderBlackBoardIntAction()
    {
    }
}
