using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource audioVO;
    public AudioSource audioLoop;
    public AudioSource audioLoopEnd;

    public GameObject audioLoopGo;
    public GameObject audioLoopEndGo;

    private bool audioCoHasStarted = false;

    // Update is called once per frame
    void Update()
    {
        if (!audioVO.isPlaying && !audioCoHasStarted)
        {
            StartCoroutine(AudioEndCo());

            //audioLoop.Stop();
            //audioLoopEnd.Play();
        }
    }
    IEnumerator AudioEndCo()
    {
        audioCoHasStarted = true;
        audioLoop.Stop();
        audioLoopEnd.Play();

        audioLoopGo.SetActive(false);
        audioLoopEndGo.SetActive(false);

        yield return new WaitForSeconds(0);
        audioCoHasStarted = false;

    }
}
