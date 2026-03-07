using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900CheckWeaponTypeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900CheckWeaponTypeAction);

    [JsonPropertyName("weaponTabaleIndex_")]
    public int WeaponTabaleIndex { get; set; } = 0; // Offset 0x30

    public Em1900CheckWeaponTypeAction()
    {
    }
}

