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

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Radis;

public class Em1805SeedAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805SeedAttackAction);

    [JsonPropertyName("seedActionType_")]
    public int SeedActionType { get; set; }

    [JsonPropertyName("seedPlacementType_")]
    public int SeedPlacementType { get; set; }

    [JsonPropertyName("paramVector_")]
    public BindingList<Param> ParamVector { get; set; } = [];

    [JsonPropertyName("moveSecondMaxAllSet_")]
    public bool MoveSecondMaxAllSet { get; set; }

    [JsonPropertyName("moveSecondMax_")]
    public float MoveSecondMax { get; set; }

    public Em1805SeedAttackAction()
    {
    }

    public class Param
    {
        [JsonPropertyName("setMoveType_")]
        public int SetMoveType { get; set; }

        [JsonPropertyName("beginPos_")]
        public Vector3 BeginPos { get; set; }

        [JsonPropertyName("endPos_")]
        public Vector3 EndPos { get; set; }

        [JsonPropertyName("moveSecondMax_")]
        public float MoveSecondMax { get; set; }

        [JsonPropertyName("waitSecond_")]
        public float WaitSecond { get; set; }

        [JsonPropertyName("CalcRotation_")]
        public bool CalcRotation { get; set; }

        [JsonPropertyName("beginCalcRotation_")]
        public bool BeginCalcRotation { get; set; }

        [JsonPropertyName("beginRotationRadius_")]
        public float BeginRotationRadius { get; set; }

        [JsonPropertyName("beginRotationAngle_")]
        public float BeginRotationAngle { get; set; }

        [JsonPropertyName("endCalcRotation_")]
        public bool EndCalcRotation { get; set; }

        [JsonPropertyName("endRotationRadius_")]
        public float EndRotationRadius { get; set; }

        [JsonPropertyName("endRotationAngle_")]
        public float EndRotationAngle { get; set; }

        [JsonPropertyName("easeParam_")]
        public EaseParam EaseParam_ { get; set; }
    }
}

