using GBFRDataTools.Entities.Parameters.Base;

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7400;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7400CoreParam : EnemyParameterInfo
{
    [JsonPropertyName("damageShakeParam_")]
    public Em7400ShakeParam DamageShakeParam { get; set; }

    public Em7400CoreParam()
    {
    }
}
