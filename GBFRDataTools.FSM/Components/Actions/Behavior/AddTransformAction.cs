using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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

    [JsonPropertyName("localMovement_")]
    [Description("Added in Endless Ragnarok. Whether to use local space rather than world space")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool LocalMovement { get; set; } = false;

    [JsonPropertyName("isUseBlackBoardValue_")]
    [Description("Added in Endless Ragnarok.")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsUseBlackBoardValue { get; set; } = false;

    [JsonPropertyName("valueName_")]
    [Description("Added in Endless Ragnarok.")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public string ValueName { get; set; }

    public override string GetCaption()
    {
        string caption;
        if (SlowRatePosition)
            caption = $"Move: Use SlowRate Pos\n";
        else if (IsUseBlackBoardValue)
            caption = $"Move: +{ValueName}";
        else
            caption = $"Move: +{AddPosition.AsVector3()}";

        if (LocalMovement)
            caption += " (Local Movement)";
        caption += "\n";

        caption += $"Rotate: +{AddRotation.AsVector3()}";
        return caption;
    }
}
