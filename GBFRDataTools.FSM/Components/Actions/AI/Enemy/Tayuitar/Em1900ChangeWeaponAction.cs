using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900ChangeWeaponAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900ChangeWeaponAction);

    public Em1900ChangeWeaponAction()
    {
    }
}

