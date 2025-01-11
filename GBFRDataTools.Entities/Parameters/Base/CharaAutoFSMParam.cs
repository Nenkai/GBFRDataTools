using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class CharaAutoFSMParam
{
    [JsonPropertyName("folderName_")]
    public string FolderName { get; set; }

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; }
}
