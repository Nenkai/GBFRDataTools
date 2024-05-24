using MessagePack;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Quest;

/// <summary>
/// stage::quest::BaseInfo
/// </summary>
[MessagePackObject]
public class BaseInfo
{
    public int Category { get; set; }
    public int SubCategory { get; set; }
    public int SerialNumber { get; set; }
    public string DifficultyHash { get; set; }
    public int Level { get; set; }
    public int Time { get; set; }
    public int LostTime { get; set; }
    public int ClearableTimes { get; set; }
    public int Overview { get; set; }
    public int Client { get; set; }
    public string MobIDHash { get; set; }
    public int SortNumber { get; set; }
    public ShortStory ShortStory { get; set; }
    public MainInfo Main { get; set; }
    public ChallengeInfo Challenge { get; set; }
    public FateEpisode FateEpisode { get; set; }
    public MultiInfo Multi { get; set; }

    /* shortStory_
     *   isPhaseMoveDelete_ - bool
     * */

    // stage::quest::OccurrenceConditions
    public List<Condition> OccurenceList { get; set; } = [];

    // stage::quest::OrderConditions
    public List<Condition> OrderList { get; set; }

    // stage::quest::SuccessConditions
    public List<Condition> SuccessList { get; set; }

    public List<Condition> FailureList { get; set; }

    // failureText_{}
    public List<string> FailureText { get; set; } = []; // max 2 elems

    public RewardInfo Reward { get; set; }
    public List<FsmDataInfo> FsmDataList { get; set; } = [];
    public List<TargetInfo> TargetList { get; set; } = [];
    public List<SubMissionsInfo> SubMissions { get; set; } = [];
    public List<SectionSortListGuid> SectionSortListGuid { get; set; } = [];
    public string LotData { get; set; }
    public List<TreasureData> TreasureData { get; set; } = [];
    public int RewardRank { get; set; }
    public PlacementsInfo PlacementsInfo { get; set; }
    public ExplacementFilesInfo ExplacementFilesInfo { get; set; }
    public EventInfo StartEventInfo { get; set; }
    public EventInfo EndEventInfo { get; set; }
    public bool IsConsumeAppend { get; set; }
    public List<int> ConsumeCounts { get; set; } = [];
    public int ClearTimeMax { get; set; }
    public int ClearTimeMin { get; set; }
    public int ResetTownTreasureType { get; set; }
    public bool ResetTownReward { get; set; }
    public List<SpecialRegulationInfo> SpecialRegulations { get; set; } = []; // Weird, this one is parsed as specialRegulations_, but files contain specialRegulationInfo_ 
    public List<ActionDropRewardInfo> ActionDropRewardList { get; set; } = [];
    public List<PreloadQuestFSMFileInfo> PreloadQuestFSMFileInfos { get; set; } = [];
    public List<PreloadVoiceEventFileInfos> PreLoadVoiceEventFileInfos { get; set; } = [];
    public int OverrideAttribute { get; set; }

    /// <summary>
    /// Unused
    /// </summary>
    public bool IsBroadcastVersion { get; set; }

    public static BaseInfo Read(byte[] data)
    {
        var reader = new MessagePackReader(data);
        
        var info = new BaseInfo();
        info.Read(ref reader);
        return info;
    }

    public int GetQuestId()
    {
        return Category << 20 | SubCategory << 12 | SerialNumber;
    }

    public void Read(ref MessagePackReader reader)
    {
        if (!reader.TryReadMapHeader(out int count))
            throw new InvalidDataException("BaseInfo messagepack file has missing map header.");

        for (int i = 0; i < count; i++)
        {
            string key = reader.ReadString();
            switch (key)
            {
                case "category_":
                    Category = int.Parse(reader.ReadString()); break;
                case "subCategory_":
                    SubCategory = int.Parse(reader.ReadString()); break;
                case "serialNumber_":
                    SerialNumber = int.Parse(reader.ReadString()); break;
                case "difficultyHash_":
                    DifficultyHash = reader.ReadString(); break;
                case "lv_":
                    Level = int.Parse(reader.ReadString()); break;
                case "time_":
                    Level = int.Parse(reader.ReadString()); break;
                case "lostTime_":
                    LostTime = int.Parse(reader.ReadString()); break;
                case "clearableTimes_":
                    ClearableTimes = int.Parse(reader.ReadString()); break;
                case "overview_":
                    Overview = int.Parse(reader.ReadString()); break;
                case "client_":
                    Client = int.Parse(reader.ReadString()); break;
                case "mobIdHash_":
                    MobIDHash = reader.ReadString(); break;
                case "sortNo_":
                    SortNumber = int.Parse(reader.ReadString()); break;
                case "shortStory_":
                    ShortStory = new ShortStory();
                    ShortStory.Read(ref reader);
                    break;
                case "main_":
                    Main = new MainInfo();
                    Main.Read(ref reader);
                    break;
                case "challenge_":
                    Challenge = new ChallengeInfo();
                    Challenge.Read(ref reader);
                    break;
                case "fateEpisode_":
                    FateEpisode = new FateEpisode();
                    FateEpisode.Read(ref reader);
                    break;
                case "multi_":
                    Multi = new MultiInfo();
                    Multi.Read(ref reader);
                    break;

                case "occurrenceList_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            Condition cond = new Condition();
                            cond.Read(ref reader);
                            OccurenceList.Add(cond);
                        }
                    }
                    break;
                case "orderList_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            Condition cond = new Condition();
                            cond.Read(ref reader);
                            OrderList.Add(cond);
                        }
                    }
                    break;
                case "successList_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            Condition cond = new Condition();
                            cond.Read(ref reader);
                            SuccessList.Add(cond);
                        }
                    }
                    break;
                case "failureList_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            Condition cond = new Condition();
                            cond.Read(ref reader);
                            FailureList.Add(cond);
                        }
                    }
                    break;
                case "reward_":
                    Reward = new RewardInfo();
                    Reward.Read(ref reader);
                    break;
                case "fsmDataList_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            FsmDataInfo info = new FsmDataInfo();
                            info.Read(ref reader);
                            FsmDataList.Add(info);
                        }
                    }
                    break;
                case "targetList_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            TargetInfo info = new TargetInfo();
                            info.Read(ref reader);
                            TargetList.Add(info);
                        }
                    }
                    break;
                case "subMissions_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            SubMissionsInfo info = new SubMissionsInfo();
                            info.Read(ref reader);
                            SubMissions.Add(info);
                        }
                    }
                    break;
                case "sectionSortListGuid_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            SectionSortListGuid guid = new SectionSortListGuid();
                            guid.Read(ref reader);
                            SectionSortListGuid.Add(guid);
                        }
                    }
                    break;
                case "lotData_":
                    LotData = reader.ReadString(); break;
                case "treasureData_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            TreasureData data = new TreasureData();
                            data.Read(ref reader);
                            TreasureData.Add(data);
                        }
                    }
                    break;
                case "rewardRank_":
                    RewardRank = int.Parse(reader.ReadString()); break;
                case "placementsInfo_":
                    PlacementsInfo = new PlacementsInfo();
                    PlacementsInfo.Read(ref reader);
                    break;
                case "exPlacementFilesInfo_":
                    ExplacementFilesInfo = new ExplacementFilesInfo();
                    ExplacementFilesInfo.Read(ref reader);
                    break;
                case "startEventInfo_":
                    StartEventInfo = new EventInfo();
                    StartEventInfo.Read(ref reader);
                    break;
                case "endEventInfo_":
                    EndEventInfo = new EventInfo();
                    EndEventInfo.Read(ref reader);
                    break;
                case "isConsumeAppend_":
                    IsConsumeAppend = bool.Parse(reader.ReadString());
                    break;
                case "consumeCounts_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            int val = int.Parse(reader.ReadString());
                            ConsumeCounts.Add(val);
                        }
                    }
                    break;
                case "clearTimeMax_":
                    ClearTimeMax = int.Parse(reader.ReadString()); break;
                case "clearTimeMin_":
                    ClearTimeMin = int.Parse(reader.ReadString()); break;
                case "resetTownTreasureType_":
                    ResetTownTreasureType = int.Parse(reader.ReadString()); break;
                case "resetTownReward_":
                    ResetTownReward = bool.Parse(reader.ReadString()); break;
                case "specialRegulationInfo_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            var info = new SpecialRegulationInfo();
                            info.Read(ref reader);
                            SpecialRegulations.Add(info);
                        }
                    }
                    break;
                case "actionDropRewardList_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            var info = new ActionDropRewardInfo();
                            info.Read(ref reader);
                            ActionDropRewardList.Add(info);
                        }
                    }
                    break;
                case "preLoadQuestFSMFileInfos_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            var info = new PreloadQuestFSMFileInfo();
                            info.Read(ref reader);
                            PreloadQuestFSMFileInfos.Add(info);
                        }
                    }
                    break;
                case "preLoadVoiceEventFileInfos_":
                    {
                        int arrayLength = reader.ReadArrayHeader();
                        for (int j = 0; j < arrayLength; j++)
                        {
                            var info = new PreloadVoiceEventFileInfos();
                            info.Read(ref reader);
                            PreLoadVoiceEventFileInfos.Add(info);
                        }
                    }
                    break;
                case "overrideAttribute_":
                    OverrideAttribute = int.Parse(reader.ReadString());
                    break;
                case "isBroadcastVersion_":
                    IsBroadcastVersion = bool.Parse(reader.ReadString());
                    break;

                default:
                    if (key.Contains("failureText_"))
                    {
                        if (FailureText.Count >= 2)
                            throw new InvalidDataException("Base info file has more than 2 failureText_ keys.");

                        FailureText.Add(reader.ReadString());
                    }
                    else
                        throw new NotImplementedException($"Property {key} not supported for BaseInfo file");
                    break;
            }
        }
    }
}
