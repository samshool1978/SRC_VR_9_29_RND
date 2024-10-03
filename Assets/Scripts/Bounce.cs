using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed = 0.75f;
    private float positionPercentage; // float changed to allow back and forth movement
    public RectTransform imageTransform; // new type chosen


    void Update()
    {
        positionPercentage = Mathf.PingPong(speed * Time.time, .1f); // determines the rate of UI movement

        // implement the positionPercentage movement
        imageTransform.anchorMin = new Vector2(imageTransform.anchorMin.x, positionPercentage);
        imageTransform.anchorMax = new Vector2(imageTransform.anchorMin.x, positionPercentage );
    }
}
