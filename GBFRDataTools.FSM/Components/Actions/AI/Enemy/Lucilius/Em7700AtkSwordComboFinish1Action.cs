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

public class Em7700AtkSwordComboFinish1Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkSwordComboFinish1Action);

    public Em7700AtkSwordComboFinish1Action()
    {
    }
}


