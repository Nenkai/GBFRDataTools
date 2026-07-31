using System;
using System.Collections.Generic;
using System.Text;

namespace GBFRDataTools.Misc.Entities.Summons;

public class SummonBaseParam
{
    public float[] ValuesPerLevel { get; set; } = new float[10];
    public int ValueDisplayMultiplier { get; set; }
}
