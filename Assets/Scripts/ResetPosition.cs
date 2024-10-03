using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    [SerializeField]
    private Vector3 startPos;
    [SerializeField]
    private Vector3 startRot;
    [SerializeField]
    private Vector3 startScale;

    public GameObject productLarge;

    private void Awake()
    {
        startPos = transform.localPosition;
        startRot = transform.localEulerAngles;
        startScale = transform.localScale;
    }

    public void resetPos()
    {


        transform.localPosition = startPos;
        transform.localEulerAngles = startRot;
        transform.localScale = startScale;

        productLarge.SetActive(false);
    }

    public void scaleUp()
    {
        transform.localScale = new Vector3(1, 1, 1);
        Debug.Log("scaled UP");
    }
}
