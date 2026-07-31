using System;
using System.Collections.Generic;
using System.Text;

namespace GBFRDataTools.Misc.Entities.Summons;

public class EquipBonusSummonReward
{
    public string BaseParamKey { get; set; }
    public string ParamName { get; set; }
    public SummonBaseParam SummonBaseParam { get; set; }
    public int Weight { get; set; }
    public List<SummonCurve> Curves { get; set; } = [];
}
