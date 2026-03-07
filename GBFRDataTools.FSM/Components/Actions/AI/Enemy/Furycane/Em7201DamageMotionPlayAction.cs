using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201DamageMotionPlayAction : EmDamageMotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201DamageMotionPlayAction);

    public Em7201DamageMotionPlayAction()
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
