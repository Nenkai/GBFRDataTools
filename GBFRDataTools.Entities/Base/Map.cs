using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Base;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Map<K, V>
{
    public BindingList<MapElement<K, V>> Elements { get; set; } = [];
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class MapElement<K, V>
{
    public K Key { get; set; }
    public V Value { get; set; }
}