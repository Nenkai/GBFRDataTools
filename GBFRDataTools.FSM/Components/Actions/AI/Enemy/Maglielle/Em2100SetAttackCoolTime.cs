using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100SetAttackCoolTime : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100SetAttackCoolTime);

    public Em2100SetAttackCoolTime()
    {
    }
}
