using System;
using System.Collections.Generic;
using System.Text;

namespace GBFRDataTools.Misc.Entities.Summons;

public class EquipBonusSummonLot
{
    public string Key { get; set; }
    public List<EquipBonusSummonReward> Choices { get; set; } = [];
    public int TotalWeight { get; set; }
}
