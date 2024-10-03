using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class PlayerNickname : NetworkBehaviour
{
    [Networked, OnChangedRender(nameof(NicknameChanged))]
    public string NetworkedNickname { get; set; } = "SomeNickname";


    void NicknameChanged()
    {
        Debug.Log($"Nickname changed to: {NetworkedNickname}");
    }


    
}
