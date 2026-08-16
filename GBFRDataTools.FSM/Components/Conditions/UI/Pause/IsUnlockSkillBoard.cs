using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Pause;

[GameSupport(GameVersion.EndlessRagnarok)]
public class IsUnlockSkillBoard : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsUnlockSkillBoard);

    [JsonPropertyName("checkOnlyCurrentMember_")]
    public bool CheckOnlyCurrentMember { get; set; } = false;
}

