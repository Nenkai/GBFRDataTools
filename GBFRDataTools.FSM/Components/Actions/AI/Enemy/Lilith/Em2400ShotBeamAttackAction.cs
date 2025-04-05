using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Lilith;

public class Em2400ShotBeamAttackAction : ShotAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2400ShotBeamAttackAction);
}
