using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine;

public class RockingMotion : MonoBehaviour
{

    float originalY;
    public float bobbingMultiplier = .5f;
    public float rollMultiplier = .4f;
    public float rollAngleMore = .4f;
    private Quaternion startRotation;

    void Start()
    {
        originalY = this.transform.position.y;
        startRotation = transform.rotation;
    }

    void Update()
    {
        BobUpAndDown();
        RollSideToSide();
        RollFrontToBack();
    }

    void BobUpAndDown()
    {
        transform.position = new Vector3(transform.position.x,
                                         originalY + ((float)Math.Sin(Time.time) * bobbingMultiplier),
                                         transform.position.z);
    }


    void RollSideToSide()
    {
        float f = Mathf.Sin(Time.time * rollMultiplier) * 10f;
        transform.rotation = startRotation * Quaternion.AngleAxis(f* rollAngleMore, Vector3.forward);
    }

    void RollFrontToBack()
    {
        float f = Mathf.Sin(Time.time * rollMultiplier) * 2f;
        transform.rotation = startRotation * Quaternion.AngleAxis(f, Vector3.left);
    }
}