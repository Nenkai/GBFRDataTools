using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetTempUnlockWarning : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetTempUnlockWarning);

    [JsonPropertyName("type_")]
    public EnumString<TempUnlockWarningType> Type { get; set; } // Offset 0x30

    public SetTempUnlockWarning()
    {
    }
}

public enum TempUnlockWarningType
{
    // キャラクター強化 = 0
    // 武器強化 = 1
    // 武器作成 = 2
    // 覚醒武器強化 = 3
    CharacterEnhancement = 0,
    WeaponEnhancement = 1,
    WeaponCreation = 2,
    AwakeningWeaponEnhancement = 3,
}
