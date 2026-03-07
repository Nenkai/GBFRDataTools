using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("Ends ALL actions/animations the AI is currently doing, returning them to an idle state")]
public class EtNpcEscapeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EtNpcEscapeAction);
}
