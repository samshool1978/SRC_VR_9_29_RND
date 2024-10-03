using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    IEnumerator WiggleRoutine()
    {

        float duration = 1f;
        float speed = 20f;
        float distance = 2f;
        float time = 0f;

        Vector3 pos = transform.localPosition;
        Vector3 startPos = transform.localPosition;

        while (time <= duration)
        {
            pos.x = Mathf.Lerp(Mathf.Sin(time * speed) * distance, 0, time / duration);
            transform.localPosition = pos;
            time += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = startPos;

    }
}
