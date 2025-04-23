using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Scene.Objects;

namespace GBFRDataTools.Entities.Converters;

public class BehaviorFunctionArgumentsConverter : JsonConverter<BehaviorFunctionArguments>
{
    public override BehaviorFunctionArguments Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartArray)
        {
            throw new JsonException();
        }

        reader.Read();

        int idx = 0;
        BehaviorFunctionArguments args = new();
        while (true)
        {
            switch (idx)
            {
                case 0:
                    if (reader.TokenType != JsonTokenType.StartArray)
                        throw new JsonException();

                    reader.Read();
                    while (reader.TokenType != JsonTokenType.EndArray)
                    {
                        args.Field0.Add(reader.GetInt32());
                        reader.Read();
                    }
                    reader.Read();
                    break;
                case 1:
                    if (reader.TokenType != JsonTokenType.StartArray)
                        throw new JsonException();

                    reader.Read();
                    while (reader.TokenType != JsonTokenType.EndArray)
                    {
                        args.Field1.Add(reader.GetUInt64());
                        reader.Read();
                    }
                    reader.Read();
                    break;
                case 2:
                    if (reader.TokenType != JsonTokenType.StartArray)
                        throw new JsonException();

                    reader.Read();
                    while (reader.TokenType != JsonTokenType.EndArray)
                    {
                        args.Field2.Add(reader.GetSingle());
                        reader.Read();
                    }
                    reader.Read();
                    break;
                case 3:
                    if (reader.TokenType != JsonTokenType.StartArray)
                        throw new JsonException();

                    reader.Read();
                    while (reader.TokenType != JsonTokenType.EndArray)
                    {
                        if (reader.TokenType == JsonTokenType.String)
                            args.BlackboardVariables.Add(reader.GetString());
                        else if (reader.TokenType == JsonTokenType.Number)
                            args.BlackboardVariables.Add(reader.GetInt32());
                        reader.Read();
                    }
                    reader.Read();
                    break;
                case 4:
                    args.Field4 = reader.GetBoolean();
                    reader.Read();
                    break;
                case 5:
                    args.Field5 = reader.GetBoolean();
                    reader.Read();
                    break;
            }
            
            idx++;
            if (reader.TokenType == JsonTokenType.EndArray)
                break;
        }

        if (reader.TokenType != JsonTokenType.EndArray)
            throw new JsonException();

        return args;
    }

    public override void Write(Utf8JsonWriter writer, BehaviorFunctionArguments value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}

