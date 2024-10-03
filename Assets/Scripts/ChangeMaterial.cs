using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material originalMat;
    public Material newMat;


    public void changeMaterialNew()
    {

        this.gameObject.GetComponent<Renderer>().material = newMat;
    }

    public void changeMaterialOrig()
    {

        this.gameObject.GetComponent<Renderer>().material = originalMat;
    }
}
