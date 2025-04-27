using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300PostBaseAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300PostBaseAttackAction);

    public Em7300PostBaseAttackAction()
    {
    }
}
