using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Base;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class GuiImportableCurve<T>
{
    public BindingList<T> Params { get; set; } = [];
    public string CurveFile { get; set; }

    public void Add(T element)
    {
        Params.Add(element);
    }
}
