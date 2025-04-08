using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotDamageAction : ShotHitBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotDamageAction);

    [JsonPropertyName("layer_")]
    public int Layer { get; set; } = 0;

    [JsonPropertyName("hp_")]
    public int Hp { get; set; } = 1;

    [JsonPropertyName("damageDisp_")]
    public bool DamageDisp { get; set; } = true;

    public ShotDamageAction()
    {
        Offset = Vector4.UnitW;
        Size = Vector4.One;
        DegreeX = 0f;
        DegreeY = 0f;
        DegreeZ = 0f;
        Shape = 0;
    }
}
