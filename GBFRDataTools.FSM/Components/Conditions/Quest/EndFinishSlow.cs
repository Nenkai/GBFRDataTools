using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class EndFinishSlow : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EndFinishSlow);
}
