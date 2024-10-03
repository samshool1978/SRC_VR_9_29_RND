using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyPanelBase : MonoBehaviour
{

    [field: SerializeField, Header("LobbyPanelBase Vars")]
    public LobbyPanelType PanelType { get; private set; }
    // [SerializeField] private Animator panelAnimator;
    protected LobbyUIManager lobbyUIManager;

    public enum LobbyPanelType
    {
        None,
        CreateNicknamePanel,
        MiddleSectionPanel

    }



    public virtual void InitPanel(LobbyUIManager uiManager)
    {
        lobbyUIManager = uiManager;
    }

    public void ShowPanel()
    {
        this.gameObject.SetActive(true);
    }

    protected void ClosePanel()
    {
        this.gameObject.SetActive(false);
    }
}
