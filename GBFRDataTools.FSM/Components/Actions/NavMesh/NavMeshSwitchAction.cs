using GBFRDataTools.FSM.Components.Actions.Quest;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.NavMesh;

public class NavMeshSwitchAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(NavMeshSwitchAction);

    [JsonPropertyName("roomName_")]
    public string RoomName { get; set; } = string.Empty;

    [JsonPropertyName("index_")]
    public int Index { get; set; } = 0;
}
