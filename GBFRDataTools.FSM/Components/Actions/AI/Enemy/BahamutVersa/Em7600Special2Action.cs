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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600Special2Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600Special2Action);

    public Em7600Special2Action()
    {
    }
}

