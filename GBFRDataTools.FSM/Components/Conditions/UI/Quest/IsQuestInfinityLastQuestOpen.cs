using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class IsQuestInfinityLastQuestOpen : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsQuestInfinityLastQuestOpen);
}

