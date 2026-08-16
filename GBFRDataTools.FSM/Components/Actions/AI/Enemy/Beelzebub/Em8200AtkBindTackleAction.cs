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
public class Em8200AtkBindTackleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200AtkBindTackleAction);

    [JsonPropertyName("canCheckGuard_")]
    public bool CanCheckGuard { get; set; } = false;

    [JsonPropertyName("actType_")]
    public int ActType { get; set; } = 0;

    [JsonPropertyName("bindType_")]
    public Em8200AtkBindType BindType { get; set; } = 0;

    [JsonPropertyName("signType_")]
    public SignType_ SignType { get; set; } = SignType_.Type1;

    public enum SignType_
    {
        Type0 = 0,
        Type1 = 1,
        Type2 = 2,
    }
}

