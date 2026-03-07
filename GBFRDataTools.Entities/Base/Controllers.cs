using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Base;

public class Controllers<T> : IEnumerable<T>
{
    public List<T> Elements { get; set; } = [];

    public void Add(T element)
    {
        Elements.Add(element);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)Elements).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)Elements).GetEnumerator();
    }
}
