using System;
using System.Collections.Generic;
using System.Text;

namespace GBFRDataTools.Misc.Entities.Summons;

public class Summon
{
    public string Key { get; set; }
    public string Name { get; set; }
    public SummonLot ChanceMainTraitSummonLot { get; set; }
    public SummonLot GuaranteedMainTraitSummonLot { get; set; }
    public EquipBonusSummonLot ChanceEquipBonusSummonLot { get; set; }
    public EquipBonusSummonLot GuaranteedEquipBonusSummonLot { get; set; }
}
