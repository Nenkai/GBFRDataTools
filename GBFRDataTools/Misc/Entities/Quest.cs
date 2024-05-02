using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Misc.Entities;

public class QuestBaseInfo
{
    public string category_ { get; set; }
    public string subCategory_ { get; set; }
    public string serialNumber_ { get; set; }
    public string difficultyHash_ { get; set; }
    public string lv_ { get; set; }
    public string time_ { get; set; }
    public string lostTime_ { get; set; }
    public string clearableTimes_ { get; set; }
    public string mobIdHash_ { get; set; }
    public string sortNo_ { get; set; }
    public FateEpisode fateEpisode_ { get; set; }
    public Multi multi_ { get; set; }
    public OccurrenceList[] occurrenceList_ { get; set; }
    public object[] orderList_ { get; set; }
    public object[] successList_ { get; set; }
    public string failureText_0 { get; set; }
    public string failureText_1 { get; set; }
    public Reward reward_ { get; set; }
    public FSMDataList[] fsmDataList_ { get; set; }
    public TargetList[] targetList_ { get; set; }
    public SubMissions[] subMissions_ { get; set; }
    public SectionSortListGuid[] sectionSortListGuid_ { get; set; }
    public string lotData_ { get; set; }
    public TreasureData[] treasureData_ { get; set; }
    public string rewardRank_ { get; set; }
    public PlacementsInfo placementsInfo_ { get; set; }
    public ExplacementFilesInfo exPlacementFilesInfo_ { get; set; }
    public StartEventInfo startEventInfo_ { get; set; }
    public EndEventInfo endEventInfo_ { get; set; }
    public string isConsumeAppend_ { get; set; }
    public string[] consumeCounts_ { get; set; }
    public string clearTimeMax_ { get; set; }
    public string clearTimeMin_ { get; set; }
    public string resetTownTreasureType_ { get; set; }
    public object[] specialRegulationInfo_ { get; set; }
    public object[] actionDropRewardList_ { get; set; }
    public PreloadQuestFSMFileInfos[] preLoadQuestFSMFileInfos_ { get; set; }
    public PreloadVoiceEventFileInfos[] preLoadVoiceEventFileInfos_ { get; set; }
    public string overrideAttribute_ { get; set; }
    public string isBroadcastVersion_ { get; set; }
}

public class Multi
{
    public string strengthValue_ { get; set; }
    public string rcommendedCombatPower_ { get; set; }
    public string islandId_ { get; set; }
    public string gameCategory_ { get; set; }
    public string multiQuestType_ { get; set; }
    //public string location_ { get; set; } // Causes issues
    public string enemyIds_0 { get; set; }
    public string enemyNum_0 { get; set; }
    public string overwriteStatusAndReward_0 { get; set; }
    public string enemyIds_1 { get; set; }
    public string enemyNum_1 { get; set; }
    public string overwriteStatusAndReward_1 { get; set; }
    public string enemyIds_2 { get; set; }
    public string enemyNum_2 { get; set; }
    public string overwriteStatusAndReward_2 { get; set; }
    public string enemyIds_3 { get; set; }
    public string enemyNum_3 { get; set; }
    public string overwriteStatusAndReward_3 { get; set; }
    public string enemyIds_4 { get; set; }
    public string enemyNum_4 { get; set; }
    public string overwriteStatusAndReward_4 { get; set; }
    public string enemyIds_5 { get; set; }
    public string enemyNum_5 { get; set; }
    public string overwriteStatusAndReward_5 { get; set; }
    public string min_ { get; set; }
    public string max_ { get; set; }
    public string standard_ { get; set; }
    public string hasPrepareArea_ { get; set; }
    public string isQuestStartFromBossAppear_ { get; set; }
    public TargetDispInfo targetDispInfo_ { get; set; }
    public string isUltimateParameterUse_ { get; set; }
    public string isBossRush_ { get; set; }
}

public class TargetDispInfo
{
    public string textHash_ { get; set; }
    public string type_ { get; set; }
}

public class Reward
{
    public string first_ { get; set; }
    public string every_ { get; set; }
    public string rankRewards_0 { get; set; }
    public string rankRewards_1 { get; set; }
    public string rankRewards_2 { get; set; }
    public string rankRewards_3 { get; set; }
    public string rankRewards_4 { get; set; }
    public string rankRewards_5 { get; set; }
}

public class PlacementsInfo
{
    public string treasureMaxCount_ { get; set; }
    public string treasureMinCount_ { get; set; }
    public string pickMaxCount_ { get; set; }
    public string pickMinCount_ { get; set; }
    public string searchItemMaxCount_ { get; set; }
    public string searchItemMinCount_ { get; set; }
    public string archiveMaxCount_ { get; set; }
    public string archiveMinCount_ { get; set; }
    public string multiQuestCoinMaxCount_ { get; set; }
    public string multiQuestCoinMinCount_ { get; set; }
}

public class ExplacementFilesInfo
{
    public string[] suffix_ { get; set; }
}

public class StartEventInfo
{
    public string id_ { get; set; }
    public string type_ { get; set; }
}

public class EndEventInfo
{
    public string id_ { get; set; }
    public string type_ { get; set; }
}

public class OccurrenceList
{
    public string type_ { get; set; }
    public string id_ { get; set; }
    public string count_ { get; set; }
}

public class FSMDataList
{
    public string name_ { get; set; }
    public string hash_ { get; set; }
    public string suffix_ { get; set; }
}

public class TargetList
{
    public string label_ { get; set; }
    public string textLabel_ { get; set; }
    public string type_ { get; set; }
    public string id_ { get; set; }
    public string count_ { get; set; }
    public string canFail_ { get; set; }
    public string isDisplay_ { get; set; }
    public string idIndex_ { get; set; }
    public string udsId_ { get; set; }
}

public class SubMissions
{
    public string target_ { get; set; }
    public string reward_ { get; set; }
    public string firstReward_ { get; set; }
}

public class SectionSortListGuid
{
    public string guid_ { get; set; }
}

public class TreasureData
{
    public string data_ { get; set; }
}

public class PreloadQuestFSMFileInfos
{
    public Info_ info_ { get; set; }
}

public class Info_
{
    public string index_ { get; set; }
    public object[] names_ { get; set; }
}

public class PreloadVoiceEventFileInfos
{
    public Info_1 info_ { get; set; }
}

public class Info_1
{
    public string index_ { get; set; }
    public string[] names_ { get; set; }
}


public class FateEpisode
{
    public string isStartEventTown_ { get; set; }
    public string isEndEventTown_ { get; set; }
    public string townType_ { get; set; }
    public string hasStartEvent_ { get; set; }
    public string hasEndEvent_ { get; set; }
    public string hasStartTelop_ { get; set; }
    public string hasClearTelop_ { get; set; }
    public string gameCategory_ { get; set; }
    public string location_ { get; set; }
    public Fo_ fo_ { get; set; }
}

public class Fo_
{
    public string textHash_ { get; set; }
    public string type_ { get; set; }
}
