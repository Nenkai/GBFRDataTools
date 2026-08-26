using GBFRDataTools.Entities;
using GBFRDataTools.FSM;
using GBFRDataTools.FSM.Components;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy;
using GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;
using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Components.Actions.Behavior;
using GBFRDataTools.FSM.Components.Actions.BlackBoard;
using GBFRDataTools.FSM.Components.Actions.Motion;
using GBFRDataTools.FSM.Components.Actions.Summon;
using GBFRDataTools.FSM.Components.Actions.Summon.Specific.Ahriman;
using GBFRDataTools.FSM.Components.Actions.Summon.Specific.BallisticBallista;
using GBFRDataTools.FSM.Components.Actions.Summon.Specific.Behemoth;
using GBFRDataTools.FSM.Components.Actions.Summon.Specific.DroitaMother;
using GBFRDataTools.FSM.Components.Actions.Summon.Specific.GoblinSoldier;
using GBFRDataTools.FSM.Components.Conditions.AI.Enemy;
using GBFRDataTools.FSM.Components.Conditions.AI.PlayerAI;
using GBFRDataTools.FSM.Components.Conditions.Battle;
using GBFRDataTools.FSM.Components.Conditions.BlackBoard;
using GBFRDataTools.FSM.Entities;
using GBFRDataTools.Hashing;

using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GBFRDataTools.Misc;

public class BlackboardKeyDumper
{
    /* Dumps all blackboard fsm keys used by fsm files
     * The game may use/expose more, but there's thousands of calls made to hash (blackboard keys are hashed - CRC32(BlackBoardKey))
     * that it's impractical to go through each one of them in a disassembler like IDA/Ghidra.. painful..
     * For instance there's 2027 calls made to the function responsible for getting a blackboard bool
     * (signature: 55 41 57 41 56 41 55 41 54 56 57 53 48 83 EC ? 48 8D 6C 24 ? 48 C7 45 ? ? ? ? ? 4D 89 CF 4C 89 C6 49 89 D6 49 89 CC 41 0F B6 00 48 B9 ? ? ? ? ? ? ? ? 48 31 C1 48 B8 ? ? ? ? ? ? ? ? 48 0F AF C8 41 0F B6 50 ? 48 31 CA 48 0F AF D0 41 0F B6 48 ? 48 31 D1 48 0F AF C8 45 0F B6 68 ? 49 31 CD 4C 0F AF E8 49 8B 4C 24 ? 4C 21 E9 49 8B 54 24 ? 48 89 C8 48 C1 E0 ? 48 8B 7C 02 ? 49 3B 7C 24 ? 74 ? 8B 06 3B 47 ? 74 ? 48 01 C9 48 8B 1C CA 66 0F 1F 44 00 ? 48 39 DF 74 ? 48 8B 7F ? 3B 47 ? 75 ? 31 C0 E9 ? ? ? ? 48 89 FB 48 B8 ? ? ? ? ? ? ? ? 49 39 44 24 ? 0F 84 ? ? ? ? 48 8D 0D ? ? ? ? 48 8D 15 ? ? ? ? E8 ? ? ? ? 8B 05 ? ? ? ? 65 48 8B 0C 25 ? ? ? ? 48 8B 04 C1 48 8B 88 ? ? ? ? 48 8B 41 ? 48 8B 78 ? 40 F6 C7 ? 0F 94 C2 48 85 FF 0F 84 ? ? ? ? 84 D2 0F 84 ? ? ? ? FF 40 ? 48 8B 0F 48 89 48 ? 8B 06 89 47 ? 41 0F B6 07)
     */
    public static void Dump(string extractedSystemFolder)
    {
        Dictionary<string, (string, BehaviorTreeComponent)> _v = [];

        foreach (var file in Directory.GetFiles(extractedSystemFolder, "*.msg", SearchOption.AllDirectories))
        {
            if (!file.Contains("\\behavior") && !file.Contains("\\fsm"))
                continue;

            string json = MessagePackSerializer.ConvertToJson(File.ReadAllBytes(file));
            JsonDocument doc = JsonDocument.Parse(json);

            string fileName = Path.GetRelativePath(extractedSystemFolder, file);
            foreach (var elem in doc.RootElement.EnumerateObject())
            {
                //Depth(_v, fileName, elem);

                if (!FSMParser.ComponentNameToType.TryGetValue(elem.Name, out Type componentType))
                    continue;

                try
                {
                    BehaviorTreeComponent component = (BehaviorTreeComponent)elem.Value.Deserialize(componentType, DefaultJsonSerializerOptions.InstanceForRead);
                    switch (component)
                    {
                        case BlackBoardVecCalcAction blackboardVecCalc:
                            _v.TryAdd(blackboardVecCalc.ParamBlackBoardValueName ?? string.Empty, (fileName, component));
                            break;
                        case BlackBoardVecLerpAction blackboardVecLerpAction:
                            _v.TryAdd(blackboardVecLerpAction.ValueName ?? string.Empty, (fileName, component));
                            break;
                        case RandomBlackBoardInt randomBlackboardInt:
                            _v.TryAdd(randomBlackboardInt.IntName ?? string.Empty, (fileName, component));
                            break;
                        case BlackBoardAction blackboardAction:
                            _v.TryAdd(blackboardAction.ValueName ?? string.Empty, (fileName, component));
                            break;
                        case RegisterBlackBoardAction regBlackboardAction:
                            _v.TryAdd(regBlackboardAction.ValueName ?? string.Empty, (fileName, component));
                            break;
                        case BlackBoardCompareIntCondition BlackBoardCompareIntCondition:
                            _v.TryAdd(BlackBoardCompareIntCondition.ValueNameL ?? string.Empty, (fileName, component));
                            _v.TryAdd(BlackBoardCompareIntCondition.ValueNameR ?? string.Empty, (fileName, component));
                            break;
                        case BlackBoardCompareFloatCondition BlackBoardCompareFloatCondition:
                            _v.TryAdd(BlackBoardCompareFloatCondition.ValueNameL ?? string.Empty, (fileName, component));
                            _v.TryAdd(BlackBoardCompareFloatCondition.ValueNameR ?? string.Empty, (fileName, component));
                            break;
                        case BlackBoardConditionBase BlackBoardConditionBase:
                            _v.TryAdd(BlackBoardConditionBase.ValueNameL ?? string.Empty, (fileName, component));
                            _v.TryAdd(BlackBoardConditionBase.ValueNameR ?? string.Empty, (fileName, component));
                            break;
                        case BlackBoardIntCondition BlackBoardIntCondition:
                            _v.TryAdd(BlackBoardIntCondition.IntName ?? string.Empty, (fileName, component));
                            break;
                        case BlackBoardFloatCondition BlackBoardFloatCondition:
                            _v.TryAdd(BlackBoardFloatCondition.ValueName ?? string.Empty, (fileName, component));
                            break;
                        case BlackBoardVectorCondition BlackBoardVectorCondition:
                            _v.TryAdd(BlackBoardVectorCondition.ValueName ?? string.Empty, (fileName, component));
                            break;
                        case BlackBoardBoolCondition BlackBoardBoolCondition:
                            _v.TryAdd(BlackBoardBoolCondition.BoolName ?? string.Empty, (fileName, component));
                            break;
                        case EmMovePassAction EmMovePassAction:
                            _v.TryAdd(EmMovePassAction.EnableBlackBoardBoolName ?? string.Empty, (fileName, component));
                            break;
                        case VanishObjectVFXAction VanishObjectVFXAction:
                            _v.TryAdd(VanishObjectVFXAction.BlackBoardName ?? string.Empty, (fileName, component));
                            break;
                        case CallObjectVFXAction CallObjectVFXAction:
                            _v.TryAdd(CallObjectVFXAction.BlackBoardName ?? string.Empty, (fileName, component));
                            break;
                        case AIMoveAction AIMoveAction:
                            _v.TryAdd(AIMoveAction.PositionBBName ?? string.Empty, (fileName, component));
                            break;
                        case ShotMoveParentBlackBoardVecAction shotMoveParent:
                            _v.TryAdd(shotMoveParent.VecParentBlackBoardKey ?? string.Empty, (fileName, component));
                            break;
                        case AddTransformAction addTransform:
                            _v.TryAdd(addTransform.ValueName ?? string.Empty, (fileName, component));
                            break;
                        case BlendMotionPlayAction blendMotionPlayAction:
                            _v.TryAdd(blendMotionPlayAction.BlendRateBBValueName ?? string.Empty, (fileName, component));
                            break;
                        case TimerAction TimerAction:
                            _v.TryAdd(TimerAction.BbTimeName ?? string.Empty, (fileName, component));
                            break;
                        case SummonCreateAhrimanLaser createLaser:
                            _v.TryAdd(createLaser?.LaserParam?.BbCompKey ?? string.Empty, (fileName, component));
                            break;
                        case SummonMoveAhrimanLaser SummonMoveAhrimanLaser:
                            _v.TryAdd(SummonMoveAhrimanLaser.AnimSpeedBBName ?? string.Empty, (fileName, component));
                            break;
                        case SummonCalcMoveAmountAction SummonCalcMoveAmountAction:
                            _v.TryAdd(SummonCalcMoveAmountAction.BbKey ?? string.Empty, (fileName, component));
                            break;
                        case SummonCalcBBPosAction SummonCalcBBPosAction:
                            _v.TryAdd(SummonCalcBBPosAction.PosBBName ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonCalcBBPosAction.ForwardBBName ?? string.Empty, (fileName, component));
                            break;
                        case SummonCheckWallRotateAction SummonCheckWallRotateAction:
                            _v.TryAdd(SummonCheckWallRotateAction.RotOutputBlackBoardValueName ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonCheckWallRotateAction.IsNoValidDirectionValueName ?? string.Empty, (fileName, component));
                            break;
                        case SummonFirstHitPosAction SummonFirstHitPosAction:
                            _v.TryAdd(SummonFirstHitPosAction.PosBlackBoardValueName ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonFirstHitPosAction.HitBlackBoardValueName ?? string.Empty, (fileName, component));
                            break;
                        case SummonMoveBBPosAction SummonMoveBBPosAction:
                            _v.TryAdd(SummonMoveBBPosAction.TargetBBName ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonMoveBBPosAction.HomingBBName ?? string.Empty, (fileName, component));
                            break;
                        case SummonPlayerSetPosAction SummonPlayerSetPosAction:
                            _v.TryAdd(SummonPlayerSetPosAction.BbPosKey ?? string.Empty, (fileName, component));
                            break;
                        case SummonRandomUnitSelectAction SummonRandomUnitSelectAction:
                            _v.TryAdd(SummonRandomUnitSelectAction.OrderBlackBoard ?? string.Empty, (fileName, component));
                            break;
                        case SummonSeAction SummonSeAction:
                            _v.TryAdd(SummonSeAction.BlackBoardValueName ?? string.Empty, (fileName, component));
                            break;
                        case SummonSearchHomingTargetAction SummonSearchHomingTargetAction:
                            _v.TryAdd(SummonSearchHomingTargetAction.BlackBoardPosKey ?? string.Empty, (fileName, component));
                            break;
                        case SummonSetPosAction SummonSetPosAction:
                            _v.TryAdd(SummonSetPosAction.BbPosKey ?? string.Empty, (fileName, component));
                            break;
                        case SummonSetRotAction SummonSetRotAction:
                            _v.TryAdd(SummonSetRotAction.BbRotKey ?? string.Empty, (fileName, component));
                            break;
                        case SummonSetStickFloatAction SummonSetStickFloatAction:
                            _v.TryAdd(SummonSetStickFloatAction.BlackBoardValueName ?? string.Empty, (fileName, component));
                            break;
                        case SummonSetStickVectorAction SummonSetStickVectorAction:
                            _v.TryAdd(SummonSetStickVectorAction.BlackBoardValueName ?? string.Empty, (fileName, component));
                            break;
                        case SummonSetUnitParameterAction SummonSetUnitParameterAction:
                            _v.TryAdd(SummonSetUnitParameterAction.TargetBBName ?? string.Empty, (fileName, component));
                            break;
                        case SummonSniperModeMotionAction SummonSniperModeMotionAction:
                            _v.TryAdd(SummonSniperModeMotionAction.VecOutputBlackBoardKey ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonSniperModeMotionAction.SniperPosBlackBoardKey ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonSniperModeMotionAction.RotOutputBlackBoardKey ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonSniperModeMotionAction.IsCanControlBlackBoardKey ?? string.Empty, (fileName, component));
                            break;
                        case SummonSniperModeAction SummonSniperModeAction:
                            _v.TryAdd(SummonSniperModeAction.SniperPosBlackBoardKey ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonSniperModeAction.RotOutputBlackBoardKey ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonSniperModeAction.IsCanControlBlackBoardKey ?? string.Empty, (fileName, component));
                            break;
                        case SummonSortByDistanceAction SummonSortByDistanceAction:
                            _v.TryAdd(SummonSortByDistanceAction.OrderBlackBoard ?? string.Empty, (fileName, component));
                            break;
                        case SummonStickMoveAction SummonStickMoveAction:
                            _v.TryAdd(SummonStickMoveAction.IsControlBbKey ?? string.Empty, (fileName, component));
                            break;
                        case SummonSyncMotionBlendRateAction SummonSyncMotionBlendRateAction:
                            _v.TryAdd(SummonSyncMotionBlendRateAction.BlendRateBBValueName ?? string.Empty, (fileName, component));
                            break;
                        case SummonTargetMarkerAction SummonTargetMarkerAction:
                            _v.TryAdd(SummonTargetMarkerAction.BlackBoardValueName ?? string.Empty, (fileName, component));
                            break;
                        case SummonTargetShotAction SummonTargetShotAction:
                            _v.TryAdd(SummonTargetShotAction.BlackBoardValueName ?? string.Empty, (fileName, component));
                            break;
                        case SummonTurnHomingTargetAction SummonTurnHomingTargetAction:
                            _v.TryAdd(SummonTurnHomingTargetAction.TargetPosBBName ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonTurnHomingTargetAction.TargetPosResultBBName ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonTurnHomingTargetAction.ExternalTargetPosBBName ?? string.Empty, (fileName, component));
                            break;

                        case SummonSoftCallAction SummonSoftCallAction:
                            _v.TryAdd(SummonSoftCallAction.BeginPosBBKey ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonSoftCallAction.EndPosBBKey ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonSoftCallAction.DefineName ?? string.Empty, (fileName, component));
                            break;
                        case SummonBlackBoardTimerLoopAction SummonBlackBoardTimerLoopAction:
                            _v.TryAdd(SummonBlackBoardTimerLoopAction.TimerSecBlackBoardValueName ?? string.Empty, (fileName, component));
                            _v.TryAdd(SummonBlackBoardTimerLoopAction.TriggerBlackBoardValueName ?? string.Empty, (fileName, component));
                            break;
                        case So0d00CalcTargetPosAction So0d00CalcTargetPosAction:
                            _v.TryAdd(So0d00CalcTargetPosAction.TargetPosBBName ?? string.Empty, (fileName, component));
                            break;
                        case So3100ElectricFieldAction So3100ElectricFieldAction:
                            _v.TryAdd(So3100ElectricFieldAction.BlackBoardLevelKey ?? string.Empty, (fileName, component));
                            _v.TryAdd(So3100ElectricFieldAction.BlackBoardPhaseKey ?? string.Empty, (fileName, component));
                            break;
                        case So3700SetBlackBoardBlendRateAction So3700SetBlackBoardBlendRateAction:
                            _v.TryAdd(So3700SetBlackBoardBlendRateAction.BlendRateVectorName ?? string.Empty, (fileName, component));
                            break;
                        case So4200MachineGunAndLaserAction So4200MachineGunAndLaserAction:
                            _v.TryAdd(So4200MachineGunAndLaserAction.TargetPosBbKey ?? string.Empty, (fileName, component));
                            break;
                        case So4200WaitAndBoostDashAction So4200WaitAndBoostDashAction:
                            _v.TryAdd(So4200WaitAndBoostDashAction.TargetPosBbKey ?? string.Empty, (fileName, component));
                            break;
                        case BehaviorCreateShotAction behaviorCreateShot:
                            _v.TryAdd(behaviorCreateShot.PosBlackBoardValueName ?? string.Empty, (fileName, component));
                            _v.TryAdd(behaviorCreateShot.RotBlackBoardValueName ?? string.Empty, (fileName, component));
                            break;
                        case BehaviorSetRotFromBlackBoardAction behaviorSetRot:
                            _v.TryAdd(behaviorSetRot.RotBlackBoardKey ?? string.Empty, (fileName, component));
                            _v.TryAdd(behaviorSetRot.RotPosBlackBoardKey ?? string.Empty, (fileName, component));
                            break;
                        case EmCombinationCondition EmCombinationCondition:
                            _v.TryAdd(EmCombinationCondition.BlackBoardBoolName ?? string.Empty, (fileName, component));
                            break;
                        case ShotParentBlackBoardIntCondition ShotParentBlackBoardIntCondition:
                            _v.TryAdd(ShotParentBlackBoardIntCondition.IntName ?? string.Empty, (fileName, component));
                            break;
                        case ShotParentBlackBoardBoolCondition ShotParentBlackBoardBoolCondition:
                            _v.TryAdd(ShotParentBlackBoardBoolCondition.BoolName ?? string.Empty, (fileName, component));
                            break;
                        case ShotParentBlackBoardConditionBase ShotParentBlackBoardConditionBase:
                            _v.TryAdd(ShotParentBlackBoardConditionBase.ValueNameL ?? string.Empty, (fileName, component));
                            _v.TryAdd(ShotParentBlackBoardConditionBase.ValueNameR ?? string.Empty, (fileName, component));
                            break;
                        case AIBattleDistanceCondition AIBattleDistanceCondition:
                            _v.TryAdd(AIBattleDistanceCondition.BoolName ?? string.Empty, (fileName, component));
                            break;
                        case ShotUserCustomTypeCondition ShotUserCustomTypeCondition:
                            _v.TryAdd(ShotUserCustomTypeCondition.BbIntName ?? string.Empty, (fileName, component));
                            break;





                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{file}: {e.Message}");
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
