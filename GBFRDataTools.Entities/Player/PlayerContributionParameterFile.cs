using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Player;

public class PlayerContributionParameterFile
{
    [JsonPropertyName(nameof(PlayerContributionParameter))]
    public PlayerContributionParameter PlayerContributionParameter { get; set; }

    public static PlayerContributionParameterFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        PlayerContributionParameterFile paramFile = JsonSerializer.Deserialize<PlayerContributionParameterFile>(text, DefaultJsonSerializerOptions.Instance);
        return paramFile;
    }
}

public class PlayerContributionParameter
{
    /// <summary>
    /// 20 elements max
    /// </summary>
    [JsonPropertyName("contributionPointArray_")]
    public BindingList<float> ContributionPointArray { get; set; }
}