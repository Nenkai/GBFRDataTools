using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using static GBFRDataTools.Entities.Parameters.Enemy.Em2100.Em2100Param.AIParam;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

[Description("Applies position/rotation change to the current entity.")]
public class AddTransformAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AddTransformAction);

    [Description("Adds the vector to this entity's position.\nNo effect if all 0.")]
    [JsonPropertyName("addPosition_")]
    public /* cVec4 */ Vector4 AddPosition { get; set; } = Vector4.Zero;

    [Description("Adds the vector to this entity's rotation.\nNo effect if all 0.")]
    [JsonPropertyName("addRotation_")]
    public /* cVec4 */ Vector4 AddRotation { get; set; } = Vector4.Zero;

    [JsonPropertyName("slowRatePosition_")]
    [Description("Uses slow rate position rather than AddPosition.")]
    public bool SlowRatePosition { get; set; } = false;

    public override string GetCaption()
    {
        string caption;
        if (SlowRatePosition)
            caption = $"Move: Use SlowRate Pos\n";
        else
            caption = $"Move: +{AddPosition.AsVector3()}\n";
        caption += $"Rotate: +{AddRotation.AsVector3()}";
        return caption;
    }
}
