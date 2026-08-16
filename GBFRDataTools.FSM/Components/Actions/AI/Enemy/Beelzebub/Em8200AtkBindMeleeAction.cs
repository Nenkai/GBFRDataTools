using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200AtkBindMeleeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200AtkBindMeleeAction);

    [JsonPropertyName("bindType_")]
    public Em8200AtkBindType BindType { get; set; } = 0;

    [JsonPropertyName("actType_")]
    public int ActType { get; set; } = 0;

    [JsonPropertyName("connectRagingChainType_")]
    public ConnectRagingChainType_ ConnectRagingChainType { get; set; } = 0;

    [JsonPropertyName("isConnectRagingChain_")]
    public bool IsConnectRagingChain { get; set; } = false;

    [JsonPropertyName("isEnableWarpApproach_")]
    public bool IsEnableWarpApproach { get; set; } = true;

    public enum ConnectRagingChainType_
    {
        Type0 = 0,
        Type1 = 1,
        Type2 = 2,
    }
}

public enum Em8200AtkBindType
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
    Type3 = 3,
    Type4 = 4,
}