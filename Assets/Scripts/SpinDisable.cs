using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinDisable : MonoBehaviour
{
    public void spinDisable()
    {
        this.gameObject.GetComponent<Spin>().enabled = false;

    }

    public void spinEnable()
    {
        this.gameObject.GetComponent<Spin>().enabled = true;

    }
}
