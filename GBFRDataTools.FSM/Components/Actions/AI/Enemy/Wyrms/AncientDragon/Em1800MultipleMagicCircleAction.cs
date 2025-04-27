using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800MultipleMagicCircleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800MultipleMagicCircleAction);

    [JsonPropertyName("scaleChangeSecond_")]
    public float ScaleChangeSecond { get; set; } = 3f; // Offset 0x80

    [JsonPropertyName("warningWaitSecond_")]
    public float WarningWaitSecond { get; set; } = 0.5f; // Offset 0x84

    [JsonPropertyName("warningSecondAILevel1_")]
    public float WarningSecondAILevel1 { get; set; } = 2f; // Offset 0x88

    [JsonPropertyName("warningSecondAILevel2_")]
    public float WarningSecondAILevel2 { get; set; } = 2f; // Offset 0x8C

    [JsonPropertyName("warningSecondAILevel3_")]
    public float WarningSecondAILevel3 { get; set; } = 1f; // Offset 0x90

    [JsonPropertyName("warningSecondAILevel4_")]
    public float WarningSecondAILevel4 { get; set; } = 0.5f; // Offset 0x94

    [JsonPropertyName("warningSecondAILevel5_")]
    public float WarningSecondAILevel5 { get; set; } = 0.5f; // Offset 0x98

    [JsonPropertyName("warningGrandsonAILevel1_")]
    public float WarningGrandsonAILevel1 { get; set; } = 2f; // Offset 0x9C

    [JsonPropertyName("warningGrandsonAILevel2_")]
    public float WarningGrandsonAILevel2 { get; set; } = 2f; // Offset 0xA0

    [JsonPropertyName("warningGrandsonAILevel3_")]
    public float WarningGrandsonAILevel3 { get; set; } = 1f; // Offset 0xA4

    [JsonPropertyName("warningGrandsonAILevel4_")]
    public float WarningGrandsonAILevel4 { get; set; } = 0.5f; // Offset 0xA8

    [JsonPropertyName("warningGrandsonAILevel5_")]
    public float WarningGrandsonAILevel5 { get; set; } = 0.5f; // Offset 0xAC

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } = 3.7f; // Offset 0xB0

    [JsonPropertyName("attackSecond_")]
    public float AttackSecond { get; set; } = 10f; // Offset 0xB4

    [JsonPropertyName("seCallFirstWaitSecond_")]
    public float SeCallFirstWaitSecond { get; set; } = 0f; // Offset 0xB8

    [JsonPropertyName("seCallNearWaitSecond_")]
    public float SeCallNearWaitSecond { get; set; } = 1f; // Offset 0xBC

    [JsonPropertyName("seCallFarWaitSecond_")]
    public float SeCallFarWaitSecond { get; set; } = 2f; // Offset 0xC0

    [JsonPropertyName("waitSecondCoefficientAILevel1_")]
    public float WaitSecondCoefficientAILevel1 { get; set; } = 1f; // Offset 0xC4

    [JsonPropertyName("waitSecondCoefficientAILevel2_")]
    public float WaitSecondCoefficientAILevel2 { get; set; } = 1f; // Offset 0xC8

    [JsonPropertyName("waitSecondCoefficientAILevel3_")]
    public float WaitSecondCoefficientAILevel3 { get; set; } = 1f; // Offset 0xCC

    [JsonPropertyName("waitSecondCoefficientAILevel4_")]
    public float WaitSecondCoefficientAILevel4 { get; set; } = 0.9f; // Offset 0xD0

    [JsonPropertyName("waitSecondCoefficientAILevel5_")]
    public float WaitSecondCoefficientAILevel5 { get; set; } = 0.75f; // Offset 0xD4

    [JsonPropertyName("waitGrandsonCoefficientAILevel1_")]
    public float WaitGrandsonCoefficientAILevel1 { get; set; } = 0.8f; // Offset 0xD8

    [JsonPropertyName("waitGrandsonCoefficientAILevel2_")]
    public float WaitGrandsonCoefficientAILevel2 { get; set; } = 0.8f; // Offset 0xDC

    [JsonPropertyName("waitGrandsonCoefficientAILevel3_")]
    public float WaitGrandsonCoefficientAILevel3 { get; set; } = 0.8f; // Offset 0xE0

    [JsonPropertyName("waitGrandsonCoefficientAILevel4_")]
    public float WaitGrandsonCoefficientAILevel4 { get; set; } = 0.8f; // Offset 0xE4

    [JsonPropertyName("waitGrandsonCoefficientAILevel5_")]
    public float WaitGrandsonCoefficientAILevel5 { get; set; } = 0.8f; // Offset 0xE8

    [JsonPropertyName("attackCollisionMargin_")]
    public float AttackCollisionMargin { get; set; } = 0.5f; // Offset 0xEC

    [JsonPropertyName("paramCount_")]
    public int ParamCount { get; set; } = 0; // Offset 0xAF0

    [JsonPropertyName("param0_")]
    public Param Param0 { get; set; } = new(); // Offset 0xF0

    [JsonPropertyName("param1_")]
    public Param Param1 { get; set; } = new(); // Offset 0x110

    [JsonPropertyName("param2_")]
    public Param Param2 { get; set; } = new(); // Offset 0x130

    [JsonPropertyName("param3_")]
    public Param Param3 { get; set; } = new(); // Offset 0x150

    [JsonPropertyName("param4_")]
    public Param Param4 { get; set; } = new(); // Offset 0x170

    [JsonPropertyName("param5_")]
    public Param Param5 { get; set; } = new(); // Offset 0x190

    [JsonPropertyName("param6_")]
    public Param Param6 { get; set; } = new(); // Offset 0x1B0

    [JsonPropertyName("param7_")]
    public Param Param7 { get; set; } = new(); // Offset 0x1D0

    [JsonPropertyName("param8_")]
    public Param Param8 { get; set; } = new(); // Offset 0x1F0

    [JsonPropertyName("param9_")]
    public Param Param9 { get; set; } = new(); // Offset 0x210

    [JsonPropertyName("param10_")]
    public Param Param10 { get; set; } = new(); // Offset 0x230

    [JsonPropertyName("param11_")]
    public Param Param11 { get; set; } = new(); // Offset 0x250

    [JsonPropertyName("param12_")]
    public Param Param12 { get; set; } = new(); // Offset 0x270

    [JsonPropertyName("param13_")]
    public Param Param13 { get; set; } = new(); // Offset 0x290

    [JsonPropertyName("param14_")]
    public Param Param14 { get; set; } = new(); // Offset 0x2B0

    [JsonPropertyName("param15_")]
    public Param Param15 { get; set; } = new(); // Offset 0x2D0

    [JsonPropertyName("param16_")]
    public Param Param16 { get; set; } = new(); // Offset 0x2F0

    [JsonPropertyName("param17_")]
    public Param Param17 { get; set; } = new(); // Offset 0x310

    [JsonPropertyName("param18_")]
    public Param Param18 { get; set; } = new(); // Offset 0x330

    [JsonPropertyName("param19_")]
    public Param Param19 { get; set; } = new(); // Offset 0x350

    [JsonPropertyName("param20_")]
    public Param Param20 { get; set; } = new(); // Offset 0x370

    [JsonPropertyName("param21_")]
    public Param Param21 { get; set; } = new(); // Offset 0x390

    [JsonPropertyName("param22_")]
    public Param Param22 { get; set; } = new(); // Offset 0x3B0

    [JsonPropertyName("param23_")]
    public Param Param23 { get; set; } = new(); // Offset 0x3D0

    [JsonPropertyName("param24_")]
    public Param Param24 { get; set; } = new(); // Offset 0x3F0

    [JsonPropertyName("param25_")]
    public Param Param25 { get; set; } = new(); // Offset 0x410

    [JsonPropertyName("param26_")]
    public Param Param26 { get; set; } = new(); // Offset 0x430

    [JsonPropertyName("param27_")]
    public Param Param27 { get; set; } = new(); // Offset 0x450

    [JsonPropertyName("param28_")]
    public Param Param28 { get; set; } = new(); // Offset 0x470

    [JsonPropertyName("param29_")]
    public Param Param29 { get; set; } = new(); // Offset 0x490

    [JsonPropertyName("param30_")]
    public Param Param30 { get; set; } = new(); // Offset 0x4B0

    [JsonPropertyName("param31_")]
    public Param Param31 { get; set; } = new(); // Offset 0x4D0

    [JsonPropertyName("param32_")]
    public Param Param32 { get; set; } = new(); // Offset 0x4F0

    [JsonPropertyName("param33_")]
    public Param Param33 { get; set; } = new(); // Offset 0x510

    [JsonPropertyName("param34_")]
    public Param Param34 { get; set; } = new(); // Offset 0x530

    [JsonPropertyName("param35_")]
    public Param Param35 { get; set; } = new(); // Offset 0x550

    [JsonPropertyName("param36_")]
    public Param Param36 { get; set; } = new(); // Offset 0x570

    [JsonPropertyName("param37_")]
    public Param Param37 { get; set; } = new(); // Offset 0x590

    [JsonPropertyName("param38_")]
    public Param Param38 { get; set; } = new(); // Offset 0x5B0

    [JsonPropertyName("param39_")]
    public Param Param39 { get; set; } = new(); // Offset 0x5D0

    [JsonPropertyName("param40_")]
    public Param Param40 { get; set; } = new(); // Offset 0x5F0

    [JsonPropertyName("param41_")]
    public Param Param41 { get; set; } = new(); // Offset 0x610

    [JsonPropertyName("param42_")]
    public Param Param42 { get; set; } = new(); // Offset 0x630

    [JsonPropertyName("param43_")]
    public Param Param43 { get; set; } = new(); // Offset 0x650

    [JsonPropertyName("param44_")]
    public Param Param44 { get; set; } = new(); // Offset 0x670

    [JsonPropertyName("param45_")]
    public Param Param45 { get; set; } = new(); // Offset 0x690

    [JsonPropertyName("param46_")]
    public Param Param46 { get; set; } = new(); // Offset 0x6B0

    [JsonPropertyName("param47_")]
    public Param Param47 { get; set; } = new(); // Offset 0x6D0

    [JsonPropertyName("param48_")]
    public Param Param48 { get; set; } = new(); // Offset 0x6F0

    [JsonPropertyName("param49_")]
    public Param Param49 { get; set; } = new(); // Offset 0x710

    [JsonPropertyName("param50_")]
    public Param Param50 { get; set; } = new(); // Offset 0x730

    [JsonPropertyName("param51_")]
    public Param Param51 { get; set; } = new(); // Offset 0x750

    [JsonPropertyName("param52_")]
    public Param Param52 { get; set; } = new(); // Offset 0x770

    [JsonPropertyName("param53_")]
    public Param Param53 { get; set; } = new(); // Offset 0x790

    [JsonPropertyName("param54_")]
    public Param Param54 { get; set; } = new(); // Offset 0x7B0

    [JsonPropertyName("param55_")]
    public Param Param55 { get; set; } = new(); // Offset 0x7D0

    [JsonPropertyName("param56_")]
    public Param Param56 { get; set; } = new(); // Offset 0x7F0

    [JsonPropertyName("param57_")]
    public Param Param57 { get; set; } = new(); // Offset 0x810

    [JsonPropertyName("param58_")]
    public Param Param58 { get; set; } = new(); // Offset 0x830

    [JsonPropertyName("param59_")]
    public Param Param59 { get; set; } = new(); // Offset 0x850

    [JsonPropertyName("param60_")]
    public Param Param60 { get; set; } = new();  // Offset 0x870

    [JsonPropertyName("param61_")]
    public Param Param61 { get; set; } = new();  // Offset 0x890

    [JsonPropertyName("param62_")]
    public Param Param62 { get; set; } = new();  // Offset 0x8B0

    [JsonPropertyName("param63_")]
    public Param Param63 { get; set; } = new();  // Offset 0x8D0

    public Em1800MultipleMagicCircleAction()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Param
    {
        [JsonPropertyName("offset_")]
        public Vector3 Offset { get; set; } // Offset 0x8

        [JsonPropertyName("waitSecond_")]
        public float WaitSecond { get; set; } // Offset 0x14

        [JsonPropertyName("beginScale_")]
        public float BeginScale { get; set; } // Offset 0x18

        [JsonPropertyName("endScale_")]
        public float EndScale { get; set; } // Offset 0x1C

        public Param()
        {
        }
    }
}
