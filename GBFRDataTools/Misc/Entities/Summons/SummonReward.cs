using System;
using System.Collections.Generic;
using System.Text;

using static GBFRDataTools.Misc.SummonSumarizer;

namespace GBFRDataTools.Misc.Entities.Summons;

public class SummonReward
{
    public string SkillId { get; set; }
    public string SkillName { get; set; }
    public int Weight { get; set; }
    public List<SummonCurve> Curves { get; set; } = [];
}
