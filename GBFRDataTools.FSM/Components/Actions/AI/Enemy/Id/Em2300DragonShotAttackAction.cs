using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Id;

public class Em2300DragonShotAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2300DragonShotAttackAction);

    public Em2300DragonShotAttackAction()
    {
    }
}