using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementCockpit : MonoBehaviour
{

    public GameObject loadingIcon;
    public string nextSceneName;

    public void returnAirbase()
    {

        StartCoroutine(returnAirbaseCo());

    }

    IEnumerator returnAirbaseCo()
    {
        yield return new WaitForSeconds(0);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextSceneName);

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
}
