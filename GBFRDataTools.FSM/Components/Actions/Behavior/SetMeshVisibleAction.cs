using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SetMeshVisibleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetMeshVisibleAction);

    [JsonPropertyName("meshSettings_")]
    public BindingList<MeshSetting> MeshSettings { get; set; } = []; // std::vector<BT::SetMeshVisibleAction::MeshSetting>

    [JsonPropertyName("isOtherMeshAllVisible_")]
    public bool IsOtherMeshAllVisible { get; set; } = false;

    [JsonPropertyName("isOtherMeshAllInvisible_")]
    public bool IsOtherMeshAllInvisible { get; set; } = false;

    public class MeshSetting /* SetMeshVisibleAction::MeshSetting */
    {
        [JsonPropertyName("meshIndex_")]
        public int MeshIndex { get; set; }

        [JsonPropertyName("isVisible_")]
        public bool IsVisible { get; set; }
    }
}
