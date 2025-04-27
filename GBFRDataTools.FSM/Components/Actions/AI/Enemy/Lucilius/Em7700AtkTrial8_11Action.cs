using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkTrial8_11Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkTrial8_11Action);

    public Em7700AtkTrial8_11Action()
    {
    }
}


