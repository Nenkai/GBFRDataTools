using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.SaveFile;

public enum SaveIDType
{
    // 803/811 - ? (changes on trivial save)
    // 812 - Game timer (hours played)
    // 834 - Player Name

    /// <summary>
    /// Type: <see cref="ushort"/>
    /// </summary>
    SAVEDATA_1001 = 1001,

    /// <summary>
    /// Type: <see cref="ushort"/>
    /// </summary>
    SAVEDATA_1002 = 1002,

    /// <summary>
    /// Random value/seed. This is generated at first.
    /// </summary>
    SAVEDATA_HASHSEED = 1003,

    /// <summary>
    /// Type: <see cref="ushort"/> - Unknown
    /// </summary>
    USERDATA_1101 = 1101,

    /// <summary>
    /// Type: <see cref="int"/> - UNKNOWN
    /// </summary>
    USERDATA_1102 = 1102,

    /// <summary>
    /// Type: <see cref="int"/> - UNKNOWN
    /// </summary>
    USERDATA_1103 = 1103,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_RUPIES = 1104,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_1105 = 1105,

    /// <summary>
    /// Number of commendations (Int)
    /// </summary>
    USERDATA_COMMENDATIONS = 1106,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    USERDATA_1107 = 1107,

    /// <summary>
    /// Online Status (ULong)
    /// </summary>
    USERDATA_ONLINE_STATUS_FLAGS = 1108,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_1109 = 1109,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_1110 = 1110,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_1111 = 1111,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    USERDATA_MASTERY_POINTS = 1112,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    USERDATA_1113 = 1113,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    USERDATA_1151 = 1151,

    /// <summary>
    /// Type: <see cref="int"/> - Current location (convert to hex). Direct "st" file
    /// </summary>
    CURRENT_LOCATION_STAGE_ID = 1201,

    /// <summary>
    /// Type: <see cref="byte"/>
    /// </summary>
    CURRENT_LOCATION_1202 = 1202,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    CURRENT_LOCATION_1203 = 1203,

    /// <summary>
    /// Type: <see cref="float[4]"/>
    /// </summary>
    CURRENT_LOCATION_1204 = 1204,

    /// <summary>
    /// Type: <see cref="float[4]"/>
    /// </summary>
    CURRENT_LOCATION_1205 = 1205,

    /// <summary>
    /// Party Health (<see cref="int[4]"/>)
    /// </summary>
    PARTY_HEALTH = 1206,

    /// <summary>
    /// Type: <see cref="int[4]"/>
    /// </summary>
    CURRENT_LOCATION_1207 = 1207,

    // 1402 - Weapon Slot ID

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Item ID Hash i.e ITEM_01_0000 (DB1D4F35)
    /// </summary>
    ITEMDATA_ITEM_ID = 1801,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ITEMDATA_ITEM_COUNT = 1802,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEMDATA_ITEM_FLAGS = 1803,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEMDATA_1804 = 1804,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEMDATA_1805 = 1805,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEMDATA_1806 = 1806,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ITEMDATA_1807 = 1807,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Item/Gem IDs i.e GEEN_146_04 (DA9136A1)
    /// </summary>
    ITEMJUNK_CURIO_REWARD_ITEMID = 1901,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ITEMJUNK_CURIO_REWARD_1902 = 1902,

    /// <summary>
    /// Type: <see cref="uint"/> - Seed maybe?
    /// </summary>
    ITEMJUNK_CURIO_REWARD_1903 = 1903,

    /// <summary>
    /// Type: <see cref="int"/> - Level maybe?
    /// </summary>
    ITEMJUNK_CURIO_REWARD_1904 = 1904,

    /// <summary>
    /// Type: <see cref="uint"/> - Starts from 1000
    /// </summary>
    ITEMJUNK_SEEDCOUNTER = 2001,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Curio Item IDs i.e ITEM_19_0001 (F42D8C01)
    /// </summary>
    ITEMJUNK_CURIO_IDS = 2002,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEMJUNK_CURIO_ITEM_SEEDS = 2003,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    ITEMJUNK_2004 = 2004,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEM_UNK_MAX_SLOT_ID = 2101,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Item IDs i.e ITEM_19_0001 (F42D8C01)
    /// </summary>
    ITEM_UNK_ITEM_ID = 2102,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEM_UNK_SLOT_IDS = 2103,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    ITEM_UNK_2104 = 2104,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ITEM_UNK_FLAGS = 2105,

    // 2201 - Current Party (character ids)

    // 2509 - Current Position

    ///////////////////
    // 512 entries
    ///////////////////
    /// <summary>
    /// UInt. Quest ids.
    /// </summary>
    QUESTSYSTEM_QUEST_IDS = 2570,

    /// <summary>
    /// UInt. Quest ids.
    /// </summary>
    QUESTSYSTEM_QUEST_COMPLETECOUNT = 2571,

    /// <summary>
    /// UInt.
    /// </summary>
    QUESTSYSTEM_QUEST_UNK2 = 2572,

    /// <summary>
    /// UInt.
    /// </summary>
    QUESTSYSTEM_QUEST_UNK3 = 2573,

    /// <summary>
    /// UInt.
    /// </summary>
    QUESTSYSTEM_QUEST_FLAGS = 2574,

    /// <summary>
    /// Bool.
    /// </summary>
    QUESTSYSTEM_QUEST_UNK5 = 2575,

    /// <summary>
    /// Bool.
    /// </summary>
    QUESTSYSTEM_QUEST_UNK6 = 2576,

    /// <summary>
    /// Bool.
    /// </summary>
    QUESTSYSTEM_QUEST_UNK7 = 2577,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    GEMDATA_MAX_SLOT_ID = 2701,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    GEMDATA_SLOT_IDS = 2702,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Gem ID Hash i.e GEEN_140_00 (1C4D37E4)
    /// </summary>
    GEMDATA_GEM_ID = 2703,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    GEMDATA_SKILL_1_LEVEL = 2704,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Chara ID Hash i.e PL0500 (DD7A151E)
    /// </summary>
    GEMDATA_WORN_BY = 2706,

    /// <summary>
    /// Type: <see cref="uint"/> - Flags. 1 = Locked, 2 = Unknown
    /// </summary>
    GEMDATA_FLAGS = 2707,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    GEMDATA_2708 = 2708,

    /// <summary>
    /// Type: <see cref="uint"/> Weapon ID Hash. (Hash)
    /// </summary>
    WEAPONDATA_WEAPON_ID = 2803,

    /// <summary>
    /// Type: <see cref="uint"/> Weapon XP. (Hash)
    /// </summary>
    WEAPONDATA_WEAPON_XP = 2804,

    /// <summary>
    /// Type: <see cref="int"/> - UNKNOWN
    /// </summary>
    WEAPONDATA_WEAPON_2805 = 2805,

    /// <summary>
    /// Type: <see cref="int"/> - UNKNOWN
    /// </summary>
    WEAPONDATA_WEAPON_2806 = 2806,

    /// <summary>
    /// Type: <see cref="int"/> - UNKNOWN
    /// </summary>
    WEAPONDATA_WEAPON_2807 = 2807,

    /// <summary>
    /// Type: <see cref="uint"/> - UNKNOWN
    /// </summary>
    WEAPONDATA_WEAPON_2814 = 2814,

    /// <summary>
    /// Type: <see cref="uint"/> Flags - UNKNOWN
    /// </summary>
    WEAPONDATA_WEAPON_2815 = 2815,

    /// <summary>
    /// Type: <see cref="uint"/> Flags
    /// </summary>
    WEAPONDATA_WEAPON_STONE_ITEM_ID = 2816,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Ability ID Hash.
    /// </summary>
    ABILITYDATA_ABILITY_ID = 3903,

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    ABILITYDATA_ABILITY_FLAGS = 3904,

    // 4302 - Game Options - Gameplay - Invert Vertical Look
    // 4303 - Game Options - Gameplay - Invert Horizontal Look
    // 4305 - Game Options - Gameplay - Camera Repositioning (Bool)
    // 4307 - Game Options - Gameplay - Battle Camera Repositioning (Bool)
    // 4310 - Game Options - Gameplay - Auto Dash (Bool)
    // 4312 - Game Options - Gameplay - Auto Target Switching (Bool)
    // 4313 - Game Options - Gameplay - Vibration (Bool)
    // 4315 - Game Options - Gameplay - Difficulty Type
    // 4316 - Game Options - Gameplay - Assist Mode
    // 4317 - Game Options - Gameplay - Auto Save (Bool)
    // 4318 - Game Options - Gameplay - Autoplay Dialogue (Bool)
    // 4319 - Game Options - Gameplay - Screen Shake (Bool)
    // 4321 - Game Options - Control Scheme - Guard/Lock On Buttons (Bool)
    // 4322 - Game Options - Gameplay - Communication Wheel Selection Stick
    // 4324 - Game Options - Gameplay - Autoplay Fate Episode (Bool)
    // 4326 - Game Options - Gameplay - Override Hold SBA for Chain Bursting (Bool)
    // 4327 - Game Options - Gameplay - Skybound Art Target Priority
    // 4328 - Game Options - Gameplay - Skybound Art Activation
    // 4329 - Game Options - Gameplay - Camera Terrain Adjustment
    // 4330 - Game Options - Gameplay - Quest Cutscene Auto-Skip (Bool)
    // 4331 - Game Options - Gameplay - Loading Screen Skip (Bool)
    // 4332 - Game Options - Gameplay - Navyrngate (Bool)
    // 4333 - Game Options - Gameplay - Camera Sensitivity (Vertical)
    // 4334 - Game Options - Gameplay - Camera Sensitivity (Horizontal)
    // 4335 - Game Options - Gameplay - Aim Sensitivity (Vertical)
    // 4336 - Game Options - Gameplay - Aim Sensitivity (Horizontal)
    // 4337 - Game Options - Gameplay - Camera Smoothing (Bool)
    // 4338 - Game Options - Gameplay - Battle Camera Correction (Bool)
    // 4339 - Game Options - Gameplay - Enable Map (Bool)
    // 4340 - Game Options - Gameplay - Auto Close Map (Bool)

    // 4412 - Game Options - Network Settings - Profile Visibility
    // 4413 - Co-Op Settings - Edit Profile - Player Name
    // 4420 - Control Scheme - Scheme Type
    // 4421 - Game Options - Control Scheme - Skill/Dodge Buttons (Bool)

    // 4501 - Co-Op Settings - Player List - Followed Player Steam IDs

    // Unit IDs:
    // - 10600 - Self
    // - 10700+ - Following
    // - 10800+ - Following again?
    // - 10900-10949 = Recent Player
    // - 11000 - Self again?

    /// <summary>
    /// Co-Op Settings - Edit Profile - Favorite Character (Int)
    /// </summary>
    ONLINEPLAYERLIST_CHARA_ID = 4601,

    /// <summary>
    /// Co-Op Settings - Edit Profile - Badge (Int)
    /// </summary>
    ONLINEPLAYERLIST_4602 = 4602,

    /// <summary>
    /// Co-Op Settings - Edit Profile - Badge
    /// </summary>
    ONLINEPLAYERLIST_4603 = 4603,

    /// <summary>
    /// Co-Op Settings - Edit Profile - About Me (String Array)
    /// </summary>
    ONLINEPLAYERLIST_ABOUTME = 4604,

    /// <summary>
    ///Co-Op Settings - Edit Profile - Availability Start (2 int)
    /// </summary>
    ONLINEPLAYERLIST_AVAILABILITY_START = 4605,

    /// <summary>
    /// Co-Op Settings - Edit Profile - Availability End (2 int)
    /// </summary>
    ONLINEPLAYERLIST_AVAILABILITY_END = 4606,

    // 4703 - Player Page - Commendations
    // 4804 - Most used characters for questing
    // 4901 - Quests cleared

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Island ID Hash i.e ISLAND_1ST (9C9B9723)
    /// </summary>
    ISLANDDATA_ISLAND_ID = 6101,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    ISLANDDATA_6102 = 6102,

    // 6201 - Communication - Emotes - Ids (for reordering)
    // 6301 - Communication - Stickers - Ids (for reordering)
    // 6401 - Communication - Quick Chat - ?
    // 6402 - Communication - Quick Chat - Emote

    /// <summary>
    /// Type: <see cref="uint"/>
    /// </summary>
    UNK_6801 = 6801,

    /// <summary>
    /// Type: <see cref="int"/>
    /// </summary>
    GACHADATA_7001 = 7001,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Maps to gacha table
    /// </summary>
    GACHADATA_GACHA_ID = 7002,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    GACHADATA_7003 = 7003,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Maps to menu_unlock table
    /// </summary>
    UNLOCKDATA_UNLOCK_ID = 7101,

    /// <summary>
    /// Type: <see cref="bool"/>
    /// </summary>
    UNLOCKDATA_IS_UNLOCKED = 7102,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Maps to menu_unlock table
    /// </summary>
    UNLOCKDATA_7103 = 7103,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - Gem ID Hash i.e GEEN_140_00 (1C4D37E4)
    /// </summary>
    ACQUIREDGEMS_GEM_ID = 8001,

    /// <summary>
    /// Type: <see cref="uint"/> (Hash) - 1 = acquired?
    /// </summary>
    ACQUIREDGEMS_ACQUIRED_FLAG = 8002,

    // 8908 - Online Status Updates? Incremented when changing online status
    // 8909 - Online Status Updates 2? Incremented when changing online status
    // 8916 - Game Options - Keyboard - Battle Controls (Byte Array, Key codes)
    // 8918 - Game Options - Keyboard - Town Controls (Byte Array, Key codes)
    // 8934 - Game Options - Keyboard - Photo Mode Controls (Byte Array, Key codes)
}
