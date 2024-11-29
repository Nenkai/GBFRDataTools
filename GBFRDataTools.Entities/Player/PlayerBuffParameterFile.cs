using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using MessagePack;

namespace GBFRDataTools.Entities.Player;

public class PlayerBuffParameterFile
{
    [JsonPropertyName(nameof(PlayerBuffParameter))]
    public PlayerBuffParameter PlayerBuffParameter { get; set; }

    public static PlayerBuffParameterFile Read(byte[] data, bool isMessagePackFile = false)
    {
        string text;
        if (isMessagePackFile)
            text = MessagePackSerializer.ConvertToJson(data);
        else
            text = Encoding.UTF8.GetString(data);

        PlayerBuffParameterFile paramFile = JsonSerializer.Deserialize<PlayerBuffParameterFile>(text, DefaultJsonSerializerOptions.Instance);
        return paramFile;
    }
}

public class PlayerBuffParameter
{
    [JsonPropertyName("illusionInInvisibleTime_")]
    public float IllusionInInvisibleTime { get; set; } = 1.0f;

    [JsonPropertyName("aiSelectUseAbilityType_")]
    public int AiSelectUseAbilityType { get; set; } = 0;
}
