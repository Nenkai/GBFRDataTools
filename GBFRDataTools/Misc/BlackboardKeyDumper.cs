using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using GBFRDataTools.Entities;
using GBFRDataTools.FSM;
using GBFRDataTools.FSM.Components.Actions.BlackBoard;
using GBFRDataTools.FSM.Entities;
using GBFRDataTools.FSM.Components.Conditions.BlackBoard;
using GBFRDataTools.FSM.Components;
using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

using MessagePack;

using GBFRDataTools.Hashing;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy;
using GBFRDataTools.FSM.Components.Conditions.Battle;

namespace GBFRDataTools.Misc;

public class BlackboardKeyDumper
{
    /* Dumps all blackboard fsm keys used by fsm files
     * The game may use/expose more, but there's thousands of calls made to hash (blackboard keys are hashed - CRC32(BlackBoardKey))
     * that it's impractical to go through each one of them in a disassembler like IDA/Ghidra.. painful..
     * For instance there's 2027 calls made to the function responsible for getting a blackboard bool
     * (signature: 55 41 57 41 56 41 55 41 54 56 57 53 48 83 EC ? 48 8D 6C 24 ? 48 C7 45 ? ? ? ? ? 4D 89 CF 4C 89 C6 49 89 D6 49 89 CC 41 0F B6 00 48 B9 ? ? ? ? ? ? ? ? 48 31 C1 48 B8 ? ? ? ? ? ? ? ? 48 0F AF C8 41 0F B6 50 ? 48 31 CA 48 0F AF D0 41 0F B6 48 ? 48 31 D1 48 0F AF C8 45 0F B6 68 ? 49 31 CD 4C 0F AF E8 49 8B 4C 24 ? 4C 21 E9 49 8B 54 24 ? 48 89 C8 48 C1 E0 ? 48 8B 7C 02 ? 49 3B 7C 24 ? 74 ? 8B 06 3B 47 ? 74 ? 48 01 C9 48 8B 1C CA 66 0F 1F 44 00 ? 48 39 DF 74 ? 48 8B 7F ? 3B 47 ? 75 ? 31 C0 E9 ? ? ? ? 48 89 FB 48 B8 ? ? ? ? ? ? ? ? 49 39 44 24 ? 0F 84 ? ? ? ? 48 8D 0D ? ? ? ? 48 8D 15 ? ? ? ? E8 ? ? ? ? 8B 05 ? ? ? ? 65 48 8B 0C 25 ? ? ? ? 48 8B 04 C1 48 8B 88 ? ? ? ? 48 8B 41 ? 48 8B 78 ? 40 F6 C7 ? 0F 94 C2 48 85 FF 0F 84 ? ? ? ? 84 D2 0F 84 ? ? ? ? FF 40 ? 48 8B 0F 48 89 48 ? 8B 06 89 47 ? 41 0F B6 07)
     */
    static void Dump()
    {
        Dictionary<string, (string, BehaviorTreeComponent)> _v = [];

        string dir = @"<path to system folder>";
        foreach (var file in Directory.GetFiles(dir, "*.msg", SearchOption.AllDirectories))
        {
            if (!file.Contains("\\behavior") && !file.Contains("\\fsm"))
                continue;

            string json = MessagePackSerializer.ConvertToJson(File.ReadAllBytes(file));
            JsonDocument doc = JsonDocument.Parse(json);

            FSMNode lastNode = null;
            int layerWithNodesIndex = -1;

            string fileName = Path.GetRelativePath(dir, file);
            foreach (var elem in doc.RootElement.EnumerateObject())
            {
                //Depth(_v, fileName, elem);

                if (!FSMParser.ComponentNameToType.TryGetValue(elem.Name, out Type componentType))
                    continue;

                try
                {
                    BehaviorTreeComponent component = (BehaviorTreeComponent)elem.Value.Deserialize(componentType, DefaultJsonSerializerOptions.InstanceForRead);
                    if (component is BlackBoardAction blackboardAction)
                    {
                        _v.TryAdd(blackboardAction.ValueName, (fileName, component));
                    }
                    else if (component is RegisterBlackBoardAction regBlackboardAction)
                    {
                        _v.TryAdd(regBlackboardAction.ValueName, (fileName, component));
                    }
                    else if (component is ShotParentBlackBoardIntCondition ShotParentBlackBoardIntCondition)
                    {
                        _v.TryAdd(ShotParentBlackBoardIntCondition.IntName, (fileName, component));
                    }
                    else if (component is ShotParentBlackBoardConditionBase ShotParentBlackBoardConditionBase)
                    {
                        _v.TryAdd(ShotParentBlackBoardConditionBase.ValueNameL, (fileName, component));
                        _v.TryAdd(ShotParentBlackBoardConditionBase.ValueNameR, (fileName, component));
                    }
                    else if (component is BlackBoardConditionBase BlackBoardConditionBase)
                    {
                        _v.TryAdd(BlackBoardConditionBase.ValueNameL, (fileName, component));
                        _v.TryAdd(BlackBoardConditionBase.ValueNameR, (fileName, component));
                    }
                    else if (component is BlackBoardIntCondition BlackBoardIntCondition)
                    {
                        _v.TryAdd(BlackBoardIntCondition.IntName, (fileName, component));
                    }
                    else if (component is BlackBoardFloatCondition BlackBoardFloatCondition)
                    {
                        _v.TryAdd(BlackBoardFloatCondition.ValueName, (fileName, component));
                    }
                    else if (component is BlackBoardBoolCondition BlackBoardBoolCondition)
                    {
                        _v.TryAdd(BlackBoardBoolCondition.BoolName, (fileName, component));
                    }
                    else if (component is EmMovePassAction EmMovePassAction)
                    {
                        _v.TryAdd(EmMovePassAction.EnableBlackBoardBoolName, (fileName, component));
                    }
                    else if (component is VanishObjectVFXAction VanishObjectVFXAction)
                    {
                        _v.TryAdd(VanishObjectVFXAction.BlackBoardName, (fileName, component));
                    }
                    else if (component is CallObjectVFXAction CallObjectVFXAction)
                    {
                        _v.TryAdd(CallObjectVFXAction.BlackBoardName, (fileName, component));
                    }
                    else if (component is AIMoveAction AIMoveAction)
                    {
                        _v.TryAdd(AIMoveAction.PositionBBName, (fileName, component));
                    }
                }
                catch (Exception e)
                {
                    continue;
                }
            }

        }

        using (var sw = File.CreateText("blackboard_keys.txt"))
        {
            foreach (var v in _v)
            {
                sw.WriteLine($"{v.Key}|{v.Value.Item2?.GetType()?.Name ?? ""}|0x{CRC32.crc32_0x77073096(v.Key, toLower: false):X8}|{v.Value.Item1.Replace('\\', '/')}");
            }
        }
    }
}
