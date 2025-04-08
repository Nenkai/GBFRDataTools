using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001LightShotExplosionAction : ShotHitBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001LightShotExplosionAction);

    [JsonPropertyName("explosionVfxScale_")]
    public float ExplosionVfxScale { get; set; } = 3.0f;

    public Em7001LightShotExplosionAction()
    {
        Offset = Vector4.UnitW;
        Size = Vector4.One;
        DegreeX = 0f;
        DegreeY = 0f;
        DegreeZ = 0f;
        Shape = 0;
    }
}
