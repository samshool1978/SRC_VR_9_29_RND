using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenLoader : MonoBehaviour
{

    public GameObject loadingIcon;
    public string nextSceneName;
    public float nextSceneWait;

    void Awake()
    {
        StartCoroutine(NextSceneCo());
    }


    public void nextSceneStop()
    {

        StopCoroutine(NextSceneCo());

    }

    IEnumerator NextSceneCo()
    {
        yield return new WaitForSeconds(nextSceneWait);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextSceneName);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            loadingIcon.SetActive(true);
            yield return null;
        }
    }
}