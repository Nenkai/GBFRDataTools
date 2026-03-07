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

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Radis;

public class Em1805FrontBeamAction : Em1800FireBallAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805FrontBeamAction);

    public Em1805FrontBeamAction()
    {
    }
}


