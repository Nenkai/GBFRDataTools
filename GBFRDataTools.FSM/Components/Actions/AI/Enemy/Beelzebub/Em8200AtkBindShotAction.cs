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

using static GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub.Em8200AtkBindMeleeAction;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200AtkBindShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200AtkBindShotAction);

    [JsonPropertyName("actType_")]
    public int ActType { get; set; } = 0;

    [JsonPropertyName("bindType_")]
    public Em8200AtkBindType BindType { get; set; } = 0;

    [JsonPropertyName("isChangeShot4_")]
    public bool IsChangeShot4 { get; set; } = false;

    [JsonPropertyName("startSign_")]
    public bool StartSign { get; set; } = false;

    [JsonPropertyName("enableEscape_")]
    public bool EnableEscape { get; set; } = true;
}

