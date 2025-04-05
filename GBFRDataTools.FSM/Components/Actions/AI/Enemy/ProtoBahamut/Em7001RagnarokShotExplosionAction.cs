﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.ProtoBahamut;

public class Em7001RagnarokShotExplosionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001RagnarokShotExplosionAction);

    [JsonPropertyName("explosionVfxScale_")]
    public float ExplosionVfxScale { get; set; } = 3.0f;
}
