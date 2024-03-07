using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GBFRDataTools.Misc;

public class JsonKeyGrabber
{
    public static void Print(string jsonFile)
    {
        var options = new JsonDocumentOptions
        {
            AllowTrailingCommas = true,
            CommentHandling = JsonCommentHandling.Skip
        };

        using (JsonDocument document = JsonDocument.Parse(File.ReadAllText(jsonFile), options))
        {
            foreach (JsonProperty property in document.RootElement.EnumerateObject())
            {
                foreach (JsonElement subProp in property.Value.EnumerateArray())
                {
                    foreach (JsonProperty propProp in subProp.EnumerateObject())
                    {
                        var idHash = propProp.Value.GetProperty("id_hash_").GetString();
                        if (idHash.StartsWith("TXT_ITEM") && !idHash.Contains("ITEM_INFO_"))
                        {
                            string id = idHash.Substring(4);
                            string itemName = propProp.Value.GetProperty("text_").GetString();
                            Console.WriteLine($"{id},{itemName}");
                        }
                    }
                }
            }
        }
    }
}
