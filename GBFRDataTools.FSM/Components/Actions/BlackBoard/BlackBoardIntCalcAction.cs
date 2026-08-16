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
public class BlackBoardIntCalcAction : BlackBoardAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardIntCalcAction);

    [JsonPropertyName("calcType_")]
    public BlackBoardCalcType CalcType { get; set; } = 0; // Offset 0x40

    [JsonPropertyName("calcValue_")]
    public int CalcValue { get; set; } = 0; // Offset 0x44

    public override string GetCaption()
    {
        string str = CalcType switch
        {
            BlackBoardCalcType.Plus => $"{ValueName} += {CalcValue}",
            BlackBoardCalcType.Minus => $"{ValueName} -= {CalcValue}",
            BlackBoardCalcType.Multiply => $"{ValueName} *= {CalcValue}",
            BlackBoardCalcType.Divide => $"{ValueName} /= {CalcValue}",
            BlackBoardCalcType.Modulo => $"{ValueName} %= {CalcValue}",
            _ => $"{ValueName} ?? {CalcValue}",
        };

        if (SetTiming != 0)
            str += $" (after {SetTiming}s)";

        return str;
    }
}