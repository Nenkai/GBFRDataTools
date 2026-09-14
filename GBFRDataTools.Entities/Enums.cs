using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Game name for it.")]
public enum eObjIdType
{
    pl = 0x10000, // Player
    em = 0x20000, // Enemy
    wp = 0x30000, // Weapon
    et = 0x40000, // Entity?
    ef = 0x50000,
    it = 0x70000, // Interaction?
    sc = 0x90000,
    bg = 0xC0000,
    bh = 0xE0000,
    ba = 0xF0000,
    fp = 0x1000000, // Face Player
    fe = 0x1010000, // Face Enemy
    fn = 0x1020000, // Face NPC
    we = 0x1030000, // Weapon Enemy
    wn = 0x1040000, // Weapon NPC
    np = 0x10A0000, // NPC
    tr = 0x10B0000,
    bt = 0x10C0000,
    so = 0x10D0000, // Summon Object
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

    // Endless Ragnarok
    NoteFSM = 69,
    EndlessBuff = 70,
    EndlessInteract = 71,
    EndlessResult = 72,
    SynopsisMovie = 73,
    HudEndless = 74,
    WorldMapAnimFSM = 75,
    Unk76 = 76,
    EndlessInteractTop = 77,
    PauseSkillBoard = 78,
    GhostEmployment = 79,
    ResidentEndless = 80,
    EndlessHistoriathTop = 81,
    EndlessHistoriath = 82,
    EndlessCommon = 83,
    HudInformation = 84,
    EndlessAreaResult = 85,
    EndlessRestTop = 86,
    EndlessRest = 87,
    EndlessMainMenuTop = 88,
    EndlessMainMenu = 89,
    EndlessRoulette = 90,
    EndlessActiveBuff = 91,
    EndlessTutorial = 92,
    ShopSubCommon = 93,
    ShopTrade = 94,
    ShopTicket = 95,
    ShopGene = 96,
    ShopGeneMix = 97,
    ShopChara = 98,
    ShopWeapon = 99,
    ShopDLC = 100,
    QuestCounterSelect = 101,
    QuestCounterShuffle = 102,
    QuestCounterOnline = 103,
    QuestCounterChapterSelect = 104,
    QuestCounterFateEpisode = 105,
    QuestCounterSelectConfirm = 106,
    EndlessFormationTop = 107,
    EndlessFormation = 108,
    Unk109 = 109,
    QuestCounterInfinity = 110,
    BlacksmithUpgrade = 111,
    BlacksmithCraft = 112,
    BlacksmithGene = 113,
    Unk114 = 114,
    BlacksmithCode = 115,
    QuestPrologue = 116,
    ThanksInfinity = 117,
    EndlessGiftAcquired = 118,
    PausePlayerList = 119,
    PauseBlockList = 120,
    NoteStory = 121,
    NotePicture = 122,
    NoteArchive = 123,
    NoteWordlist = 124,
    NoteTips = 125,
    NoteBadge = 126,
    NoteBgm = 127
}

/// <summary>
/// Used by FSM components (DebuffData), and by seq_edit_track.bxm files.
/// </summary>
public enum DebuffDataCategory : uint
{
    CategoryUnset = 0,

    [Display(Order = 100)]
    CategoryNone_67AE4C55 = 0x67AE4C55,

    [Display(Order = 200)]
    CategoryAilment_78D65167 = 0x78D65167,

    [Display(Order = 300)]
    Category2_9CD39782 = 0x9CD39782,
}

/// <summary>
/// Used by FSM components (DebuffData), and by seq_edit_track.bxm files.
/// </summary>
public enum DebuffDataType : uint
{
    [Display(Order = 0)]
    TypeUnset = 0,

    [Display(Order = 1000)]
    Ailment_NONE_Type0 = 0x3A104097,

    [Display(Order = 1010)]
    Ailment_BURN_Type1_StatusId1001 = 0x10D25D5C,

    [Display(Order = 1020)]
    Ailment_STUN_Type2_StatusId1003 = 0xB6F49156,

    [Display(Order = 1030)]
    Ailment_WATERBALL_Type3_StatusId1008 = 0xF6533F8E,

    [Display(Order = 1040)]
    Ailment_FROZEN_Type4_StatusId1004 = 0xCE8AF003,

    [Display(Order = 1050)]
    Ailment_STONE_Type5_StatusId1006 = 0x47BB7C64,

    [Display(Order = 1060)]
    Ailment_Type6_StatusId1009 = 0xD64D3367,

    [Display(Order = 1070)]
    Ailment_Type7_StatusId1010 = 0xC0C1D535,

    [Display(Order = 1080)]
    Ailment_PARALYZE_Type8_StatusId1007 = 0xB1508E3D,

    [Display(Order = 1090)]
    Ailment_POISON_Type9_StatusId1000 = 0x5320CE6F,

    [Display(Order = 1100)]
    Ailment_SLOW_Type10_StatusId1002 = 0x70873185,

    [Display(Order = 1110)]
    Ailment_Type11_StatusIdMinus1 = 0x993235CA,

    [Display(Order = 1120)]
    Ailment_DARKNESS_Type12_StatusId1011 = 0x034CB30B,

    [Display(Order = 1130)]
    Ailment_BIND_Type13_StatusId1012 = 0x8EB687C9,

    [Display(Order = 1140)]
    Ailment_Type14_StatusId1013 = 0x0F0FC8B5,

    [Display(Order = 1150)]
    Ailment_Type15_StatusId1014 = 0x35ABCF81,

    [Display(Order = 1160)]
    Ailment_CAPTURE_Type16_StatusId1015 = 0x62375707,

    [Display(Order = 1170)]
    Ailment_BANABILITY_Type17_StatusId1016 = 0x29635228,

    [Display(Order = 1180)]
    Ailment_BANSPARTS_Type18_StatusId1017 = 0x37E7BA96,

    [Display(Order = 1190)]
    Ailment_DIMENSIONDMG_Type19_StatusId1018 = 0x61B1700D,

    [Display(Order = 1200)]
    Ailment_FEAR_Type20_StatusId1019 = 0xF67874A6,

    [Display(Order = 1210)]
    Ailment_ARVESSFERMARE_Type21_StatusId1020 = 0xF816D1FD,

    [Display(Order = 1220)]
    Ailment_WEAKELEMENT_Type22_StatusId1021 = 0xC9932485,

    [Display(Order = 1230)]
    Ailment_Type23_StatusId1022 = 0x48841219,

    [Display(Order = 2000)]
    Category2_Type0 = 0xBD5E4FDD,

    [Display(Order = 2010)]
    Category2_Type1 = 0xD21EADD5,

    [Display(Order = 2020)]
    Category2_Type2 = 0xE7C92715,

    [Display(Order = 2030)]
    Category2_Type3 = 0xF493ECEE,

    [Display(Order = 2040)]
    Category2_Type4 = 0xF70DC616,

    [Display(Order = 2050)]
    Category2_Type5 = 0x6680BF9B,

    [Display(Order = 2060)]
    Category2_Type6 = 0x97E51570,

    [Display(Order = 2070)]
    Category2_Type7 = 0xA2329FB0,

    [Display(Order = 2080)]
    Category2_Type8 = 0x6D4F96A,
}

public enum EaseCalcType
{
    Sine = 0,
    Quad = 1,
    Cubic = 2,
    Quart = 3,
    Quint = 4,
    Expo = 5,
    Circ = 6,
    Back = 7,
    Elastic = 8,
    Bounce = 9,
}

public enum EaseCategory
{
    Out = 0,
    In = 1,
    InOut = 2,
}