using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetEquipSelectedCharaID : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetEquipSelectedCharaID);

    [JsonPropertyName("type_")]
    public EnumString<SetEquipSelectedCharaIDType> Type { get; set; } // Offset 0x30

    public SetEquipSelectedCharaID()
    {
    }
}

public enum SetEquipSelectedCharaIDType
{
    ControlledCharacter = 0, // 操作キャラ
}
