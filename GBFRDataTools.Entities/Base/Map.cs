using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Base;

public class Map<K, V>
{
    public List<MapElement<K, V>> Elements { get; set; } = [];
}

public class MapElement<K, V>
{
    public K Key { get; set; }
    public V Value { get; set; }
}