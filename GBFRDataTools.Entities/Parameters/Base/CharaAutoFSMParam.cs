using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class CharaAutoFSMParam
{
    [JsonPropertyName("folderName_")]
    public BindingList<string> FolderName { get; set; }

    [JsonPropertyName("fsmName_")]
    public BindingList<string> FsmName { get; set; }
}
