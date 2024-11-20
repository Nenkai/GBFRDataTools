using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Base;

public class Controllers<T>
{
    public List<T> Elements { get; set; } = [];

    public void Add(T element)
    {
        Elements.Add(element);
    }
}
