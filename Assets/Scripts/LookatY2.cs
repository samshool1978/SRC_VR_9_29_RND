using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookatY2 : MonoBehaviour
{
    public GameObject target;
    public RectTransform flipUI;

    private void Awake()
    {
        flipUI.localScale = new Vector3(-1, 1, 1);
    }

    void Update()
    {
        Vector3 targetPosition = new Vector3 (target.transform.position.x, transform.position.y, target.transform.position.z);

        transform.LookAt (targetPosition);
    }
}
