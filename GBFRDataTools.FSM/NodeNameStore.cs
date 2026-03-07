using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM;

public class NodeNameStore
{
    public static Dictionary<uint, string> GenericNameHashes { get; set; } = [];
    public static Dictionary<string, FSMFileNodeNameStore> FileToNodeNames { get; set; } = [];

    static NodeNameStore()
    {
        string lastFile = string.Empty;

        if (File.Exists("Data/node_names.txt"))
        {
            foreach (var line in File.ReadAllLines("Data/node_names.txt"))
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

        if (File.Exists("Data/generic_node_names.txt"))
        {
            foreach (var line in File.ReadAllLines("Data/generic_node_names.txt"))
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

    public static string TryGetNameForNode(string fileName, uint nodeId, uint nameHash)
    {
        if (FileToNodeNames.TryGetValue(fileName, out FSMFileNodeNameStore store))
        {
            if (store.NodeNames.TryGetValue(nodeId, out string nodeName))
            {
                return nodeName;
            }
        }

        if (GenericNameHashes.TryGetValue(nameHash, out string name))
            return name;

        return null;
    }
}

public class FSMFileNodeNameStore
{
    public Dictionary<uint, string> NodeNames { get; set; } = [];
}
