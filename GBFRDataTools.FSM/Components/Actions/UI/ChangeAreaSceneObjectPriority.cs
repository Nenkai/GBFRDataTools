using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class ChangeAreaSceneObjectPriority : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeAreaSceneObjectPriority);

    [JsonPropertyName("type_")]
    public EnumString<ChangeAreaSceneObjectPriorityType> Type { get; set; } // Offset 0x30

    public ChangeAreaSceneObjectPriority()
    {
    }
}

public enum ChangeAreaSceneObjectPriorityType
{
    // キャラ解放開始 = 0
    // キャラ解放終了 = 1
    CharacterReleaseBegins = 0,
    CharacterReleaseCompleted = 1,
}