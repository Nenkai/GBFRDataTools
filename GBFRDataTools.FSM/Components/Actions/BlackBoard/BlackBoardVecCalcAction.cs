using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

[GameSupport(GameVersion.EndlessRagnarok)]
public class BlackBoardVecCalcAction : BlackBoardAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardVecCalcAction);

    [JsonPropertyName("calcType_")]
    public BlackBoardCalcType CalcType { get; set; } = 0;

    [JsonPropertyName("calcVecValue_")]
    public Vector4 CalcVecValue { get; set; } = Vector4.UnitW;

    [JsonPropertyName("calcScalarValue_")]
    public float CalcScalarValue { get; set; } = 1f;

    [JsonPropertyName("isCalcBlackBoard_")]
    public bool IsCalcBlackBoard { get; set; } = false;

    [JsonPropertyName("paramBlackBoardValueName_")]
    public string ParamBlackBoardValueName { get; set; }

    public override string GetCaption()
    {
        string str = CalcType switch
        {
            BlackBoardCalcType.Plus => $"{ValueName} += {CalcVecValue}",
            BlackBoardCalcType.Minus => $"{ValueName} -= {CalcVecValue}",
            BlackBoardCalcType.Multiply => $"{ValueName} *= {CalcVecValue}",
            BlackBoardCalcType.Divide => $"{ValueName} /= {CalcVecValue}",
            BlackBoardCalcType.Modulo => $"{ValueName} %= {CalcVecValue}",
            _ => $"{ValueName} ?? {CalcVecValue}",
        };

        if (SetTiming != 0)
            str += $" (after {SetTiming}s)";

        return str;
    }
}