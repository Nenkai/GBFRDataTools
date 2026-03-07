using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

public class Em7500ChangeModeOminousExplosionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500ChangeModeOminousExplosionAction);

    public Em7500ChangeModeOminousExplosionAction()
    {
    }
}

