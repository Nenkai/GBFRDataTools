using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000BreakDamageActionParam : ActionComponent /* TODO: Is it actually? */
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000BreakDamageActionParam);

    [JsonPropertyName("comebackStartSec_")]
    public float ComebackStartSec { get; set; }
}
