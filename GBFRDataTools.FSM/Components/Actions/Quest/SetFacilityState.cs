﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetFacilityState : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetFacilityState);

    [JsonPropertyName("enable_")]
    public bool Enable { get; set; } = true;

    [JsonPropertyName("enablePause_")]
    public bool EnablePause { get; set; } = true;

    [JsonPropertyName("enableInteract_")]
    public bool EnableInteract { get; set; } = true;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
