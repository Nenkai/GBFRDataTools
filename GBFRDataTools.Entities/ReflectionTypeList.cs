using GBFRDataTools.Entities.Camera;
using GBFRDataTools.Entities.Enemy;
using GBFRDataTools.Entities.FinishCamera;
using GBFRDataTools.Entities.NPC;
using GBFRDataTools.Entities.Parameters;
using GBFRDataTools.Entities.Parameters.Enemy.Em0000;
using GBFRDataTools.Entities.Parameters.Enemy.Em0100_Skeleton;
using GBFRDataTools.Entities.Parameters.Enemy.Em0200;
using GBFRDataTools.Entities.Parameters.Enemy.Em0300;
using GBFRDataTools.Entities.Parameters.Enemy.Em0400;
using GBFRDataTools.Entities.Parameters.Enemy.Em0500_Crocodile;
using GBFRDataTools.Entities.Parameters.Enemy.Em0600_Slime;
using GBFRDataTools.Entities.Parameters.Enemy.Em0700_Ahriman;
using GBFRDataTools.Entities.Parameters.Enemy.Em0800_Seed;
using GBFRDataTools.Entities.Parameters.Enemy.Em0900_Statue;
using GBFRDataTools.Entities.Parameters.Enemy.Em1000_CultSoldier;
using GBFRDataTools.Entities.Parameters.Enemy.Em1100;
using GBFRDataTools.Entities.Parameters.Enemy.Em1200;
using GBFRDataTools.Entities.Parameters.Enemy.Em1300_Bit;
using GBFRDataTools.Entities.Parameters.Enemy.Em1500;
using GBFRDataTools.Entities.Parameters.Enemy.Em1600;
using GBFRDataTools.Entities.Parameters.Enemy.Em1700;
using GBFRDataTools.Entities.Parameters.Enemy.Em1800;
using GBFRDataTools.Entities.Parameters.Enemy.Em1900;
using GBFRDataTools.Entities.Parameters.Enemy.Em2000;
using GBFRDataTools.Entities.Parameters.Enemy.Em2100;
using GBFRDataTools.Entities.Parameters.Enemy.Em2200;
using GBFRDataTools.Entities.Parameters.Enemy.Em2300;
using GBFRDataTools.Entities.Parameters.Enemy.Em2400;
using GBFRDataTools.Entities.Parameters.Enemy.Em2600;
using GBFRDataTools.Entities.Parameters.Enemy.Em2700;
using GBFRDataTools.Entities.Parameters.Enemy.Em2800;
using GBFRDataTools.Entities.Parameters.Enemy.Em2900;
using GBFRDataTools.Entities.Parameters.Enemy.Em3000;
using GBFRDataTools.Entities.Parameters.Enemy.Em3100;
using GBFRDataTools.Entities.Parameters.Enemy.Em3400;
using GBFRDataTools.Entities.Parameters.Enemy.Em3500;
using GBFRDataTools.Entities.Parameters.Enemy.Em7000;
using GBFRDataTools.Entities.Parameters.Enemy.Em7100;
using GBFRDataTools.Entities.Parameters.Enemy.Em7200;
using GBFRDataTools.Entities.Parameters.Enemy.Em7300;
using GBFRDataTools.Entities.Parameters.Enemy.Em7400;
using GBFRDataTools.Entities.Parameters.Enemy.Em7500;
using GBFRDataTools.Entities.Parameters.Enemy.Em7600;
using GBFRDataTools.Entities.Parameters.Enemy.Em7700;
using GBFRDataTools.Entities.Parameters.Player;
using GBFRDataTools.Entities.Player;
using GBFRDataTools.Entities.Preset;
using GBFRDataTools.Entities.Vibration;
using GBFRDataTools.Entities.Voice;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities;

public class ReflectionTypeList
{
    public static List<Type> ReflectedTypes { get; } =
    [
        typeof(DamageCalculateParam),
        typeof(GuardParam),
        typeof(LinkCounterData),
        typeof(Etc300Param),
        typeof(Pl0000Param),
        typeof(Pl0100Param),
        typeof(Pl0200Param),
        typeof(Pl0300Param),
        typeof(Pl0400Param),
        typeof(Pl0500Param),
        typeof(Pl0600Param),
        typeof(Pl0700Param),
        typeof(Pl0800Param),
        typeof(Pl0900Param),
        typeof(Pl1000Param),
        typeof(Pl1100Param),
        typeof(Pl1200Param),
        typeof(Pl1300Param),
        typeof(Pl1400Param),
        typeof(Pl1500Param),
        typeof(Pl1600Param),
        typeof(Pl1700Param),
        typeof(Pl1800Param),
        typeof(Pl1900Param),
        typeof(Pl2000Param),
        typeof(Pl2100Param),
        typeof(Pl2200Param),
        typeof(Pl2300Param),
        typeof(Em0000Param),
        typeof(Em0001Param),
        typeof(Em0002Param),
        typeof(Em0003Param),
        typeof(Em0004Param),
        typeof(Em0005Param),
        typeof(Em0100Param),
        typeof(Em0101Param),
        typeof(Em0102Param),
        typeof(Em0103Param),
        typeof(Em0200Param),
        typeof(Em0201Param),
        typeof(Em0300Param),
        typeof(Em0400Param),
        typeof(Em0500Param),
        typeof(Em0501Param),
        typeof(Em0502Param),
        typeof(Em0600Param),
        typeof(Em0601Param),
        typeof(Em0602Param),
        typeof(Em0603Param),
        typeof(Em0604Param),
        typeof(Em0605Param),
        typeof(Em0701Param),
        typeof(Em0705Param),
        typeof(Em0706Param),
        typeof(Em0800Param),
        typeof(Em0801Param),
        typeof(Em0802Param),
        typeof(Em0803Param),
        typeof(Em0804Param),
        typeof(Em0805Param),
        typeof(EmSeedParam),
        typeof(Em0900Param),
        typeof(Em0902Param),
        typeof(Em1000Param),
        typeof(Em1001Param),
        typeof(Em1002Param),
        typeof(Em1003Param),
        typeof(Em1004Param),
        typeof(Em1005Param),
        typeof(Em1100Param),
        typeof(Em1200Param),
        typeof(Em1301Param),
        typeof(Em1303Param),
        typeof(Em1500Param),
        typeof(Em1600Param),
        typeof(Em1700Param),
        typeof(Em1800Param),
        typeof(Em1801Param),
        typeof(Em1802Param),
        typeof(Em1803Param),
        typeof(Em1804Param),
        typeof(Em1805Param),
        typeof(Em1806Param),
        typeof(Em1900Param),
        typeof(Em2000Param),
        typeof(Em2100Param),
        typeof(Em2200Param),
        typeof(Em2300Param),
        typeof(Em2400Param),
        typeof(Em2600Param),
        typeof(Em2700Param),
        typeof(Em2800Param),
        typeof(Em2900Param),
        typeof(Em2901Param),
        typeof(Em3000Param),
        typeof(Em3100Param),
        typeof(Em3400Param),
        typeof(Em3500Param),
        typeof(Em7000Param),
        typeof(Em7001Param),
        typeof(Em7100Param),
        typeof(Em7101Param),
        typeof(Em7200Param),
        typeof(Em7201Param),
        typeof(Em7210Param),
        typeof(Em7211Param),
        typeof(Em7300Param),
        typeof(Em7310Param),
        typeof(Em7400Param),
        typeof(Em7401Param),
        typeof(Em7404Param),
        typeof(Em7406Param),
        typeof(Em7407Param),
        typeof(Em7500Param),
        typeof(Em7520Param),
        typeof(Em7530Param),
        typeof(Em75a0Param),
        typeof(Em75b0Param),
        typeof(Em7600Param),
        typeof(Em76a0Param),
        typeof(Em7700Param),
        typeof(PlayerAbilityUIParameter),
        typeof(PlayerAilmentParameter),
        typeof(PlayerAutoHomingParameter),
        typeof(PlayerBuffParameter),
        typeof(PlayerContributionParameter),
        typeof(PlayerLinkAttackVoiceParameter),
        typeof(PlayerLockOnParameter),
        typeof(PlayerMoveParameter),
        typeof(RescueParam),
        typeof(SpecialArtsParam),
        typeof(EmCounterManagerParam),
        typeof(EquipPreset),
        typeof(CharacterInfo),
        typeof(ActionInfo),
        typeof(NPCConfig),
        typeof(NPCRole),
        typeof(ApplicationVibrationParameter),
        typeof(FinishCameraParameterInfo),
        typeof(CameraData),
        typeof(SeriousVoiceCheckData),
    ];
    public static Dictionary<string, Type> ReflectedTypeMap { get; } = [];

    static ReflectionTypeList()
    {
        foreach (var type in ReflectedTypes)
            ReflectedTypeMap.Add(type.Name, type);
    }
}
