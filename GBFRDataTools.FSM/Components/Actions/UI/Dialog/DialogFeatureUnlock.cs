using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

public class DialogFeatureUnlock : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DialogFeatureUnlock);

    [JsonPropertyName("type_")]
    public EnumString<DialogFeatureUnlockType> Type { get; set; } = new();
}

public enum DialogFeatureUnlockType
{
    // ジーン錬成 = 0,
    // 作成可能武器 = 1,
    // キャラ固有ジーン交換 = 2,
    GeenSynthesis = 0,
    WeaponsThatCanBeCreated = 1,
    CharacterSpecificGeenExchange = 2,
}