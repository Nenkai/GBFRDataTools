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

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.PyetA.Weapons;

public class We3100ConnectMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We3100ConnectMoveAction);

    public We3100ConnectMoveAction()
    {
    }
}
