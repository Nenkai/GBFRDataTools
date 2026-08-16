using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkDoubleChopAction : Em8300AtkDimensionBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkDoubleChopAction);

    public Em8300AtkDoubleChopAction()
    {
        DimensionType = 0;
    }
}