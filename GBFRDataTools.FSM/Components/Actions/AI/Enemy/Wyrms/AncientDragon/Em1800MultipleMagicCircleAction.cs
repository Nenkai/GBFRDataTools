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
    public float ScaleChangeSecond { get; set; } = 3f; 

    [JsonPropertyName("warningWaitSecond_")]
    public float WarningWaitSecond { get; set; } = 0.5f; 

    [JsonPropertyName("warningSecondAILevel1_")]
    public float WarningSecondAILevel1 { get; set; } = 2f; 

    [JsonPropertyName("warningSecondAILevel2_")]
    public float WarningSecondAILevel2 { get; set; } = 2f; 

    [JsonPropertyName("warningSecondAILevel3_")]
    public float WarningSecondAILevel3 { get; set; } = 1f; 

    [JsonPropertyName("warningSecondAILevel4_")]
    public float WarningSecondAILevel4 { get; set; } = 0.5f; 

    [JsonPropertyName("warningSecondAILevel5_")]
    public float WarningSecondAILevel5 { get; set; } = 0.5f; 

    [JsonPropertyName("warningGrandsonAILevel1_")]
    public float WarningGrandsonAILevel1 { get; set; } = 2f; 

    [JsonPropertyName("warningGrandsonAILevel2_")]
    public float WarningGrandsonAILevel2 { get; set; } = 2f; 

    [JsonPropertyName("warningGrandsonAILevel3_")]
    public float WarningGrandsonAILevel3 { get; set; } = 1f; 

    [JsonPropertyName("warningGrandsonAILevel4_")]
    public float WarningGrandsonAILevel4 { get; set; } = 0.5f; 

    [JsonPropertyName("warningGrandsonAILevel5_")]
    public float WarningGrandsonAILevel5 { get; set; } = 0.5f; 

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } = 3.7f; 

    [JsonPropertyName("attackSecond_")]
    public float AttackSecond { get; set; } = 10f; 

    [JsonPropertyName("seCallFirstWaitSecond_")]
    public float SeCallFirstWaitSecond { get; set; } = 0f; 

    [JsonPropertyName("seCallNearWaitSecond_")]
    public float SeCallNearWaitSecond { get; set; } = 1f; 

    [JsonPropertyName("seCallFarWaitSecond_")]
    public float SeCallFarWaitSecond { get; set; } = 2f; 

    [JsonPropertyName("waitSecondCoefficientAILevel1_")]
    public float WaitSecondCoefficientAILevel1 { get; set; } = 1f; 

    [JsonPropertyName("waitSecondCoefficientAILevel2_")]
    public float WaitSecondCoefficientAILevel2 { get; set; } = 1f; 

    [JsonPropertyName("waitSecondCoefficientAILevel3_")]
    public float WaitSecondCoefficientAILevel3 { get; set; } = 1f; 

    [JsonPropertyName("waitSecondCoefficientAILevel4_")]
    public float WaitSecondCoefficientAILevel4 { get; set; } = 0.9f; 

    [JsonPropertyName("waitSecondCoefficientAILevel5_")]
    public float WaitSecondCoefficientAILevel5 { get; set; } = 0.75f; 

    [JsonPropertyName("waitGrandsonCoefficientAILevel1_")]
    public float WaitGrandsonCoefficientAILevel1 { get; set; } = 0.8f; 

    [JsonPropertyName("waitGrandsonCoefficientAILevel2_")]
    public float WaitGrandsonCoefficientAILevel2 { get; set; } = 0.8f; 

    [JsonPropertyName("waitGrandsonCoefficientAILevel3_")]
    public float WaitGrandsonCoefficientAILevel3 { get; set; } = 0.8f; 

    [JsonPropertyName("waitGrandsonCoefficientAILevel4_")]
    public float WaitGrandsonCoefficientAILevel4 { get; set; } = 0.8f; 

    [JsonPropertyName("waitGrandsonCoefficientAILevel5_")]
    public float WaitGrandsonCoefficientAILevel5 { get; set; } = 0.8f; 

    [JsonPropertyName("attackCollisionMargin_")]
    public float AttackCollisionMargin { get; set; } = 0.5f; 

    [JsonPropertyName("paramCount_")]
    public int ParamCount { get; set; } = 0; 

    [JsonPropertyName("param0_")]
    public Param Param0 { get; set; } = new(); 

    [JsonPropertyName("param1_")]
    public Param Param1 { get; set; } = new(); 

    [JsonPropertyName("param2_")]
    public Param Param2 { get; set; } = new(); 

    [JsonPropertyName("param3_")]
    public Param Param3 { get; set; } = new(); 

    [JsonPropertyName("param4_")]
    public Param Param4 { get; set; } = new(); 

    [JsonPropertyName("param5_")]
    public Param Param5 { get; set; } = new(); 

    [JsonPropertyName("param6_")]
    public Param Param6 { get; set; } = new(); 

    [JsonPropertyName("param7_")]
    public Param Param7 { get; set; } = new(); 

    [JsonPropertyName("param8_")]
    public Param Param8 { get; set; } = new(); 

    [JsonPropertyName("param9_")]
    public Param Param9 { get; set; } = new(); 

    [JsonPropertyName("param10_")]
    public Param Param10 { get; set; } = new(); 

    [JsonPropertyName("param11_")]
    public Param Param11 { get; set; } = new(); 

    [JsonPropertyName("param12_")]
    public Param Param12 { get; set; } = new(); 

    [JsonPropertyName("param13_")]
    public Param Param13 { get; set; } = new(); 

    [JsonPropertyName("param14_")]
    public Param Param14 { get; set; } = new(); 

    [JsonPropertyName("param15_")]
    public Param Param15 { get; set; } = new(); 

    [JsonPropertyName("param16_")]
    public Param Param16 { get; set; } = new(); 

    [JsonPropertyName("param17_")]
    public Param Param17 { get; set; } = new(); 

    [JsonPropertyName("param18_")]
    public Param Param18 { get; set; } = new(); 

    [JsonPropertyName("param19_")]
    public Param Param19 { get; set; } = new(); 

    [JsonPropertyName("param20_")]
    public Param Param20 { get; set; } = new(); 

    [JsonPropertyName("param21_")]
    public Param Param21 { get; set; } = new(); 

    [JsonPropertyName("param22_")]
    public Param Param22 { get; set; } = new(); 

    [JsonPropertyName("param23_")]
    public Param Param23 { get; set; } = new(); 

    [JsonPropertyName("param24_")]
    public Param Param24 { get; set; } = new(); 

    [JsonPropertyName("param25_")]
    public Param Param25 { get; set; } = new(); 

    [JsonPropertyName("param26_")]
    public Param Param26 { get; set; } = new(); 

    [JsonPropertyName("param27_")]
    public Param Param27 { get; set; } = new(); 

    [JsonPropertyName("param28_")]
    public Param Param28 { get; set; } = new(); 

    [JsonPropertyName("param29_")]
    public Param Param29 { get; set; } = new(); 

    [JsonPropertyName("param30_")]
    public Param Param30 { get; set; } = new(); 

    [JsonPropertyName("param31_")]
    public Param Param31 { get; set; } = new(); 

    [JsonPropertyName("param32_")]
    public Param Param32 { get; set; } = new(); 

    [JsonPropertyName("param33_")]
    public Param Param33 { get; set; } = new(); 

    [JsonPropertyName("param34_")]
    public Param Param34 { get; set; } = new(); 

    [JsonPropertyName("param35_")]
    public Param Param35 { get; set; } = new(); 

    [JsonPropertyName("param36_")]
    public Param Param36 { get; set; } = new(); 

    [JsonPropertyName("param37_")]
    public Param Param37 { get; set; } = new(); 

    [JsonPropertyName("param38_")]
    public Param Param38 { get; set; } = new(); 

    [JsonPropertyName("param39_")]
    public Param Param39 { get; set; } = new(); 

    [JsonPropertyName("param40_")]
    public Param Param40 { get; set; } = new(); 

    [JsonPropertyName("param41_")]
    public Param Param41 { get; set; } = new(); 

    [JsonPropertyName("param42_")]
    public Param Param42 { get; set; } = new(); 

    [JsonPropertyName("param43_")]
    public Param Param43 { get; set; } = new(); 

    [JsonPropertyName("param44_")]
    public Param Param44 { get; set; } = new(); 

    [JsonPropertyName("param45_")]
    public Param Param45 { get; set; } = new(); 

    [JsonPropertyName("param46_")]
    public Param Param46 { get; set; } = new(); 

    [JsonPropertyName("param47_")]
    public Param Param47 { get; set; } = new(); 

    [JsonPropertyName("param48_")]
    public Param Param48 { get; set; } = new(); 

    [JsonPropertyName("param49_")]
    public Param Param49 { get; set; } = new(); 

    [JsonPropertyName("param50_")]
    public Param Param50 { get; set; } = new(); 

    [JsonPropertyName("param51_")]
    public Param Param51 { get; set; } = new(); 

    [JsonPropertyName("param52_")]
    public Param Param52 { get; set; } = new(); 

    [JsonPropertyName("param53_")]
    public Param Param53 { get; set; } = new(); 

    [JsonPropertyName("param54_")]
    public Param Param54 { get; set; } = new(); 

    [JsonPropertyName("param55_")]
    public Param Param55 { get; set; } = new(); 

    [JsonPropertyName("param56_")]
    public Param Param56 { get; set; } = new(); 

    [JsonPropertyName("param57_")]
    public Param Param57 { get; set; } = new(); 

    [JsonPropertyName("param58_")]
    public Param Param58 { get; set; } = new(); 

    [JsonPropertyName("param59_")]
    public Param Param59 { get; set; } = new(); 

    [JsonPropertyName("param60_")]
    public Param Param60 { get; set; } = new();  

    [JsonPropertyName("param61_")]
    public Param Param61 { get; set; } = new();  

    [JsonPropertyName("param62_")]
    public Param Param62 { get; set; } = new();  

    [JsonPropertyName("param63_")]
    public Param Param63 { get; set; } = new();  

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Param
    {
        [JsonPropertyName("offset_")]
        public Vector3 Offset { get; set; } 

        [JsonPropertyName("waitSecond_")]
        public float WaitSecond { get; set; } 

        [JsonPropertyName("beginScale_")]
        public float BeginScale { get; set; } 

        [JsonPropertyName("endScale_")]
        public float EndScale { get; set; } 
    }
}
