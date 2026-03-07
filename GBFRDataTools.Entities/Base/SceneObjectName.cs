using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Base;

/// <summary>
/// cy::SceneObjectName
/// </summary>
public class SceneObjectName
{
    public string NameStr { get; set; }

    /// <summary>
    /// CRC32
    /// </summary>
    public uint NameStrHash { get; set; }
}
