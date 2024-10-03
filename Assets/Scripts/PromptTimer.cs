using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptTimer : MonoBehaviour
{

    public float promptWaitTime;

    void Awake()
    {
        StartCoroutine(PromptTimerCo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PromptTimerCo()
    {

        yield return new WaitForSeconds(promptWaitTime);
        gameObject.SetActive(false);
    }
}
