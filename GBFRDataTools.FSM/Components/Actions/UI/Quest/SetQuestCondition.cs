using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Quest;

public class SetQuestCondition : ActionComponent
{
    public override string ComponentName => nameof(SetQuestCondition);

    [JsonPropertyName("result_")]
    public EnumString<SetQuestConditionResult> Result { get; set; } // Offset 0x30

    public override string GetCaption()
    {
        return Utils.GetEnumDescription(Result.Index);
    }

    public SetQuestCondition()
    {

    }
}

public enum SetQuestConditionResult
{
    False = 0,
    True = 1,
}