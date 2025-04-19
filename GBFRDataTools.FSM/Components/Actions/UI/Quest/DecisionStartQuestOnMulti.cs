using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Quest;

public class DecisionStartQuestOnMulti : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DecisionStartQuestOnMulti);

    public DecisionStartQuestOnMulti()
    {
    }
}