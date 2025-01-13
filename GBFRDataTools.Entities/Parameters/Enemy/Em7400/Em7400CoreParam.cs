using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7400;

public class Em7400CoreParam : EnemyParameterInfo
{
    [JsonPropertyName("damageShakeParam_")]
    public Em7400ShakeParam DamageShakeParam { get; set; }

    public Em7400CoreParam()
    {
    }
}
