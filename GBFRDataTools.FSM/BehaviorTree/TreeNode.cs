using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.BehaviorTree;

public class TreeNode
{
    [JsonPropertyName("guid_")]
    public uint Guid { get; set; }

    [JsonPropertyName("tailIndexOfChildNodeGuids_")]
    public int TailIndexOfChildNodeGuids { get; set; }

    [JsonPropertyName("tailIndexOfComponentGuids_")]
    public int TailIndexOfComponentGuids { get; set; }

    /// <summary>
    /// Non original, only for editor purposes
    /// </summary>
    [JsonPropertyName("name_")]
    public string Name { get; set; }

    /// <summary>
    /// Not used by the game or present at all, using this for external third-party editors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("boundary_box")]
    public Vector4 BoundaryBox { get; set; }

    public override string ToString()
    {
        return $"Guid: {Guid}";
    }
}
