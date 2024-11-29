using GBFRDataTools.FSM.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CompassVisible : QuestActionComponent
{
    [JsonPropertyName("visibleFlags_")]
    public BindingList<bool> VisibleFlags { get; set; } = []; // 18 elems
}
