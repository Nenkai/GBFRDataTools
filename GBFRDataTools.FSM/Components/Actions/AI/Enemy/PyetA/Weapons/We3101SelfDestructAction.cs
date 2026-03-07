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

public class We3101SelfDestructAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We3101SelfDestructAction);

    public We3101SelfDestructAction()
    {
    }
}
