using GBFRDataTools.FSM.Components.Actions.AI.Enemy;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7200DamageMotionPlayAction : EmDamageMotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200DamageMotionPlayAction);

    public Em7200DamageMotionPlayAction()
    {
        InterTime = -1f;
        AnimMoveRateXZ = 1f;
        AnimMoveRateY = 1f;
        AnimSpeedRate = 0f;
        AnimSpeedStep = 0;
        GravityRate = 0f;
        GravityRateStep = 0;
    }
}
