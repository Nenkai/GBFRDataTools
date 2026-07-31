using System;
using System.Collections.Generic;
using System.Text;

namespace GBFRDataTools.Misc.Entities.Summons;

public class SummonLot
{
    public string Key { get; set; }
    public List<SummonReward> Choices { get; set; } = [];
    public int TotalWeight { get; set; }
}
