using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class IsRunningTutorialWait : ConditionComponent
{
    [JsonPropertyName("waitName_")]
    public string WaitName { get; set; }
}
