using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class QuestStartInfomationDialog : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestStartInfomationDialog);
}
