using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmVoiceTextAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmVoiceTextAction);

    [JsonPropertyName("groupID_")]
    public string GroupID { get; set; } // Offset 0x30

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0; // Offset 0x50

    public override string GetCaption()
    {
        return $"{GroupID} - Timing: {SetTiming}";
    }

    public EmVoiceTextAction()
    {
    }
}

