using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Fusion;
using Fusion.Sockets;


public class SceneManagement : MonoBehaviour
{

    //public GameObject loadingIcon;
    public int sceneNumber;

    public GameObject sceneHome;
    public GameObject scene1;
    public GameObject scene4_6;
    public GameObject scene7_9;
    public GameObject sceneButton;
    public GameObject homeButton;
    public GameObject resumeButton;
    public GameObject nextSceneButton;

    public GameObject productA;
    public GameObject productB;

    public GameObject screens;
    public GameObject videoPlayer;

    public PlayableDirector director;
    public int resumeMissionTime;

    public GameObject productPodiums;

    public GameObject ccaInteract;

    //public Button startMissionButton;

    public GameObject loadingIcon;
    public string nextSceneName;


    public void loadScene()
    {
        StartCoroutine(LoadYourAsyncScene());
    }

    IEnumerator LoadYourAsyncScene()
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneNumber);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            //loadingIcon.SetActive(true);
            yield return null;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void sceneHomeLoad()
    {
        scene1.SetActive(false);
        sceneHome.SetActive(true);

        sceneButton.SetActive(true);
        homeButton.SetActive(false);

        screens.SetActive(true);
        videoPlayer.SetActive(true);

        productPodiums.SetActive(true);

        scene4_6.SetActive(false);
        scene7_9.SetActive(false);

    }
    public void scene1Load()
    {
        scene1.SetActive(true);
        sceneHome.SetActive(false);

        sceneButton.SetActive(false);
        homeButton.SetActive(true);

        screens.SetActive(false);
        videoPlayer.SetActive(false);

        productPodiums.SetActive(false);


    }

    public void playDirector()
    {
        director.Play();

    }
    public void pauseDirector()
    {
        director.Pause();

    }

    public void timeLoopCCA()
    {
        director.time = 76;
    }

   


    public void resumeMission()
    {
        director.time = resumeMissionTime;
    }

    public void nextScene_4_6()
    {
        scene1.SetActive(false);
        scene4_6.SetActive(true);
        resumeButton.SetActive(false);
        nextSceneButton.SetActive(true);

        productA.SetActive(false);
        productB.SetActive(false);
    }

    public void nextScene_7_9()
    {
        scene4_6.SetActive(false);
        scene7_9.SetActive(true);
        
    }

    public void CCAInteractOn()
    {
        ccaInteract.SetActive(true);
    }

    public void changeAvatar()
    {
        //AvatarEditorDeeplink.LaunchAvatarEditor();
    }

    public void enterCockpit()
    {

        StartCoroutine(enterCockpitCo());
        
    }

    IEnumerator enterCockpitCo()
    {
        yield return new WaitForSeconds(0);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextSceneName);

        //shutdown fusion
        //networkRunnerA.Shutdown();

        //SceneManager.UnloadSceneAsync("OperationsRoom_New");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            loadingIcon.SetActive(true);
            yield return null;
        }
    }

    public void restart()
    {
        SceneManager.LoadScene("SplashScreen");
    }

    /*
    //RPC CALLS
    [Rpc(RpcSources.InputAuthority, RpcTargets.All)]
    public void rpc_scene1Load()
    {
       //if(Object.)
        
        scene1.SetActive(true);
        sceneHome.SetActive(false);

        sceneButton.SetActive(false);
        homeButton.SetActive(true);

        screens.SetActive(false);
        videoPlayer.SetActive(false);

        productPodiums.SetActive(false);

    }

    [Rpc(RpcSources.InputAuthority, RpcTargets.All)]
    public void rpc_startButtonClicked()
    {
        
        startMissionButton.onClick.Invoke();
    }
    */
}
