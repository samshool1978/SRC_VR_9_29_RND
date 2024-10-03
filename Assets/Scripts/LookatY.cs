using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatY : MonoBehaviour
{
    public GameObject target;

void Update()
    {
        Vector3 targetPosition = new Vector3 (target.transform.position.x, transform.position.y, target.transform.position.z);

        transform.LookAt (targetPosition);
    }
}
