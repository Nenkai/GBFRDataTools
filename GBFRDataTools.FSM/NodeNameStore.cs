using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GBFRDataTools.FSM;

public class NodeNameStore
{
    public static Dictionary<uint, string> GenericNameHashes { get; set; } = [];
    public static Dictionary<string, FSMFileNodeNameStore> FileToNodeNames { get; set; } = [];

    public static readonly string NodeNamesPath = Path.Combine("Data", "node_names.txt");
    public static readonly string GenericNodeNamesPath = Path.Combine("Data", "node_names.txt");

    static NodeNameStore()
    {
        string lastFile = string.Empty;

        if (File.Exists(NodeNamesPath))
        {
            foreach (var line in File.ReadAllLines(NodeNamesPath))
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("//"))
                    continue;

                var parts = line.Split('|');


                switch (parts[0])
                {
                    case "set_file":
                        {
                            lastFile = parts[1];
                            if (!FileToNodeNames.ContainsKey(lastFile))
                                FileToNodeNames[lastFile] = new FSMFileNodeNameStore();
                        }
                        break;

                    case "set_node":
                        {
                            if (!uint.TryParse(parts[1], out uint nodeId))
                            {
                                Debug.WriteLine($"Unable to parse node id in node_names.txt - input: '{line[1]}'");
                                continue;
                            }

                            var nodeName = parts[2];
                            FileToNodeNames[lastFile].NodeNames.Add(nodeId, nodeName);
                        }
                        break;
                }
            }
        }

        if (File.Exists(GenericNodeNamesPath))
        {
            foreach (var line in File.ReadAllLines(GenericNodeNamesPath))
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("//"))
                    continue;

                var parts = line.Split('|');


                switch (parts[0])
                {
                    case "add_name":
                        {
                            if (!uint.TryParse(parts[1], out uint nameHash))
                            {
                                Debug.WriteLine($"Unable to parse node id in generic_node_names.txt - input: '{line[1]}'");
                                continue;
                            }

                            var name = parts[2];
                            GenericNameHashes[nameHash] = name;
                        }
                        break;
                }
            }
        }
    }

    /// <summary>
    /// Saves the node names to the specified path (if provided), otherwise defaults to <see cref="NodeNamesPath"/>
    /// </summary>
    /// <param name="path"></param>
    public static void SaveNodeNames(string? path = null)
    {
        using var writer = new StreamWriter(path ?? NodeNamesPath, append: false);

        foreach (var (file, store) in FileToNodeNames)
        {
            writer.WriteLine($"set_file|{file}");

            foreach (var (nodeId, nodeName) in store.NodeNames)
            {
                writer.WriteLine($"set_node|{nodeId}|{nodeName}");
            }
            writer.WriteLine();
        }
    }

    public static void SetNameForNode(string file, uint guid, string name)
    {
        if (!FileToNodeNames.TryGetValue(file, out FSMFileNodeNameStore? store))
        {
            store = new FSMFileNodeNameStore();
            FileToNodeNames[file] = store;
        }

        store.NodeNames[guid] = name;
    }

    public static void RemoveNameForNode(string file, uint guid)
    {
        if (FileToNodeNames.TryGetValue(file, out FSMFileNodeNameStore? store))
        {
            store.NodeNames.Remove(guid);
        }
    }

    public static string? TryGetNameForNode(string fileName, uint nodeId, uint nameHash)
    {
        if (FileToNodeNames.TryGetValue(fileName, out FSMFileNodeNameStore? store))
        {
            if (store.NodeNames.TryGetValue(nodeId, out string? nodeName))
            {
                return nodeName;
            }
        }

        if (GenericNameHashes.TryGetValue(nameHash, out string? name))
            return name;

        return null;
    }
}

public class FSMFileNodeNameStore
{
    public Dictionary<uint, string> NodeNames { get; set; } = [];
}
