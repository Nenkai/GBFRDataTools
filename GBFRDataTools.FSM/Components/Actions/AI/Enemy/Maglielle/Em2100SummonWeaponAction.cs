using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100SummonWeaponAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100SummonWeaponAction);

    [JsonPropertyName("weaponIndex_")]
    public int WeaponIndex { get; set; } = 0; // Offset 0x48

    public Em2100SummonWeaponAction()
    {
    }
}