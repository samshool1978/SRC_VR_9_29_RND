using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleUp : MonoBehaviour
{
    [SerializeField]
    private Vector3 startPos;
    [SerializeField]
    private Vector3 startRot;

    public Vector3 productBigSizeA;
    public Vector3 productSmallSizeA;

    public RectTransform buttonUp;
    public RectTransform buttonDown;

    private void Awake()
    {
        startPos = transform.localPosition;
        startRot = transform.localEulerAngles;
    }

    public void scaleUp()
    {
        //this.gameObject.transform.localScale = productBigSizeA;
        this.gameObject.transform.localScale = transform.localScale * 2;

        buttonUp.localScale = new Vector3(buttonUp.localScale.x/2, buttonUp.localScale.y / 2, buttonUp.localScale.z / 2);
        buttonDown.localScale = new Vector3(buttonDown.localScale.x / 2, buttonDown.localScale.y / 2, buttonDown.localScale.z / 2);

        Debug.Log("scale up");
    }

    public void scaleDown()
    {

        this.gameObject.transform.localScale = transform.localScale /2;

        buttonUp.localScale = new Vector3(buttonUp.localScale.x * 2, buttonUp.localScale.y * 2, buttonUp.localScale.z * 2);
        buttonDown.localScale = new Vector3(buttonDown.localScale.x * 2, buttonDown.localScale.y * 2, buttonDown.localScale.z * 2);

        transform.localPosition = startPos;
        transform.localEulerAngles = startRot;

        Debug.Log("scale up");
    }

}
