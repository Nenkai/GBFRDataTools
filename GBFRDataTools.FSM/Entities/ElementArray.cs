using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

public class ElementArray<T>
{
    public List<T> Elements { get; set; } = [];

    public void Add(T element)
    {
        Elements.Add(element);
    }
}
