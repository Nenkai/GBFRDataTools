using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Game name for it.")]
public enum eObjIdType
{
    pl = 0x10000,
    em = 0x20000,
    wp = 0x30000,
    et = 0x40000,
    ef = 0x50000,
    it = 0x70000,
    sc = 0x90000,
    bg = 0xC0000,
    bh = 0xE0000,
    ba = 0xF0000,
    fp = 0x1000000,
    fe = 0x1010000,
    fn = 0x1020000,
    we = 0x1030000,
    wn = 0x1040000,
    np = 0x10A0000,
    tr = 0x10B0000,
    bt = 0x10C0000,
}

public enum EventType
{
    // system/event/...
    None = 0,
    CtEvent = 1,
    CiEvent = 2,
    CwEvent = 3,
    EvEvent = 4,
    CnEvent = 5,
}


// Used by ui/table/asset_load_setting.yml, ui/table:asset_setup.yml, LoadAsset (fsm)
public enum AssetType
{
    None = 0,
    Resident = 1,
    System = 2,
    Common = 3,
    Hud = 4,
    Telop = 5,
    Pause = 6,
    QuestCounter = 7,
    Result = 8,
    Blacksmith = 9,
    Shop = 10,
    TrialBattle = 11,
    TrialMode = 12,
    ChallengeMission = 13,
    Logo = 14,
    Title = 15,
    Prologue = 16,
    Ending = 17,
    QuestCounterHost = 18,
    QuestCounterGuest = 19,
    Tutorial = 20,
    QuestCounterMenu = 21,
    InvitationJoin = 22,
    DemoCommon = 23,
    Dummy22 = 24,
    Cut = 25,
    Entrance = 26,
    Appraiser = 27,
    GameOver = 28,
    Staffroll = 29,
    Note = 30,
    PlayerSetup = 31,
    HudCity = 32,
    HudStage = 33,
    SavePoint = 34,
    TelopState = 35,
    WorldMapAnim = 36,
    Cinema = 37,
    Fes01 = 38,
    Fes02 = 39,
    QuestCounterCommon = 40,
    TextureInfo = 41,
    Sell = 42,
    BlacksmithTop = 43,
    ShopTop = 44,
    QuestCounterTop = 45,
    CityCommon = 46,
    PauseMain = 47,
    PauseSub = 48,
    PauseTop = 49,
    PauseFormation = 50,
    PauseEquip = 51,
    PauseAbility = 52,
    PauseUpgrade = 53,
    PauseItemList = 54,
    PauseTreasure = 55,
    PauseSideQuest = 56,
    PausePlayerSetup = 57,
    PauseProfile = 58,
    PauseCommu = 59,
    PauseSystem = 60,
    PauseQuest = 61,
    PauseStatus = 62,
    PauseStatusSkill = 63,
    PauseMyset = 64,
    RolansNote = 65,
    UpgradeTelop = 66,
    Demo = 67,
    PhotoMode = 68,
}
