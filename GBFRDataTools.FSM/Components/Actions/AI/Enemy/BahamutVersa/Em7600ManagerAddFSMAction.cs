using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.BahamutVersa;

public class Em7600ManagerAddFSMAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600ManagerAddFSMAction);

    [JsonPropertyName("charaNo_")]
    public int CharaNo { get; set; } = 0;

    [JsonPropertyName("fsmNo_")]
    public int FsmNo { get; set; } = 0;
}
