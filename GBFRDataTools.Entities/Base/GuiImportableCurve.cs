using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Base;

public class GuiImportableCurve<T>
{
    public List<T> Params { get; set; } = [];
    public string CurveFile { get; set; }

    public void Add(T element)
    {
        Params.Add(element);
    }
}
