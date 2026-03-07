using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

// There's up to 8 events it seems
[Description("""
    Check cutscene preparation event state. 
    OnEventCondition and EndEventCondition are related.

    Note: there's up to 8 events max at once internally.
    """)]
public class CheckPrepareEvents : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckPrepareEvents);
}
