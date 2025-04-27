using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.AkaManah;

public class Em7530EscapeTeleprotAction : Em7530ActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7530EscapeTeleprotAction);

    public Em7530EscapeTeleprotAction()
    {
    }
}