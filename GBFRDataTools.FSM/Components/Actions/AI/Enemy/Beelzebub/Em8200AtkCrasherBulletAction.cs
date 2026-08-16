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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200AtkCrasherBulletAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200AtkCrasherBulletAction);

    [JsonPropertyName("actType_")]
    public int ActType { get; set; } = 0;

    [JsonPropertyName("targetType_")]
    public TargetType_ TargetType { get; set; } = 0;

    public enum TargetType_
    {
        Type0 = 0,
        Type1 = 1,
    }
}