using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowNickname : MonoBehaviour
{
    public PlayerNickname pn;


    void Update()
    {
        //GetComponent<Text>().text = pn.NetworkedNickname ;
        GetComponent<TMPro.TextMeshProUGUI>().text = pn.NetworkedNickname;
    }
    
}
