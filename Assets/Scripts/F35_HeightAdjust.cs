using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F35_HeightAdjust : MonoBehaviour
{
    private void Awake()
    {
        this.transform.localPosition = new Vector3(transform.localPosition.x, 39.55f, transform.localPosition.z);
        Debug.Log("slower");
    }
}
