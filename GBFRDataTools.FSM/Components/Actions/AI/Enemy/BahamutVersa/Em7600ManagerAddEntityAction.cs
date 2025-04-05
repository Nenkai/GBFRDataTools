using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.BahamutVersa;

public class Em7600ManagerAddEntityAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600ManagerAddEntityAction);
}
