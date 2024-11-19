using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions;

public class IndividuallyBeginEventControlAction : QuestActionComponent
{
    [JsonPropertyName("isExecStart_")]
    public bool IsExecStart { get; set; }

}
