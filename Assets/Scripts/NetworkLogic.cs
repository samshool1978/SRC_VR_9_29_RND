using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using UnityEngine.UI;

public class NetworkLogic : NetworkBehaviour
{

    public Button startMissionButton;

    //RPC CALLS

    [Rpc(RpcSources.InputAuthority, RpcTargets.All)]
    public void rpc_startButtonClicked()
    {
        if(HasInputAuthority)
        {
            startMissionButton.onClick.Invoke();
        }

        
    }
    
}
