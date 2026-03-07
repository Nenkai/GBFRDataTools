using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;
using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Wilinus;

public class Em1802WeakIceLaserAction : Em1800FireBallAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802WeakIceLaserAction);

    public Em1802WeakIceLaserAction()
    {
    }
}
