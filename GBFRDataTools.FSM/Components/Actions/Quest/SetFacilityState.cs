using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetFacilityState : QuestActionComponent
{
    [JsonPropertyName("enable_")]
    public bool Enable { get; set; }

    [JsonPropertyName("enablePause_")]
    public bool EnablePause { get; set; }

    [JsonPropertyName("enableInteract_")]
    public bool EnableInteract { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
