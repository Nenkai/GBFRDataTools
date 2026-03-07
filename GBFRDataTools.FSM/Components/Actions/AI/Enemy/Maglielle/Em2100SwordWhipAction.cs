using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100SwordWhipAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100SwordWhipAction);

    public Em2100SwordWhipAction()
    {
    }
}