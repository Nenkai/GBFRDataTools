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
public class SetFaceMeshVisibleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetFaceMeshVisibleAction);

    [JsonPropertyName("meshSettings_")]
    public BindingList<MeshSetting> MeshSettings { get; set; } = []; // std::vector<BT::SetFaceMeshVisibleAction::MeshSetting>

    public class MeshSetting /* SetFaceMeshVisibleAction::MeshSetting */
    {
        [JsonPropertyName("meshIndex_")]
        public int MeshIndex { get; set; }

        [JsonPropertyName("isVisible_")]
        public bool IsVisible { get; set; }
    }
}
