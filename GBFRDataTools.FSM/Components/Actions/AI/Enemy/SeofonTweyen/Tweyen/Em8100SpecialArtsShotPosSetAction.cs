using GBFRDataTools.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Tweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8100SpecialArtsShotPosSetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100SpecialArtsShotPosSetAction);

    [JsonPropertyName("startingDirDeg_")]
    public float StartingDirDeg { get; set; } = 45f;

    [JsonPropertyName("em8100BodyLeanDeg_")]
    public float Em8100BodyLeanDeg { get; set; } = 35f;

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = new Vector4(0f, 3f, -3f, 1f);
}