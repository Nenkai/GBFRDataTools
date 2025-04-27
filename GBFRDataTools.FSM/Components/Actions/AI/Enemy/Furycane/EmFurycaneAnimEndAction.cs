using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class EmFurycaneAnimEndAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmFurycaneAnimEndAction);

    public EmFurycaneAnimEndAction()
    {
    }
}





