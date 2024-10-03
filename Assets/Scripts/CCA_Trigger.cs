using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCA_Trigger : MonoBehaviour
{
    public Transform productA;
    public Transform productB;
    public Vector3 productBigSizeA;
    public Vector3 productSmallSizeA;
    public Vector3 productBigSizeB;
    public Vector3 productSmallSizeB;


    private void OnTriggerEnter(Collider other)
    {

         if(other.gameObject.tag == "Product")
        {
            productA.localScale = productSmallSizeA;
            Debug.Log("enter");
        }
        if (other.gameObject.tag == "ProductB")
        {
            productA.localScale = productSmallSizeB;
            Debug.Log("enter");
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Product")
        {
            productA.localScale = productBigSizeA;
            Debug.Log("exit");
        }
        if (other.gameObject.tag == "ProductB")
        {
            productA.localScale = productBigSizeB;
            Debug.Log("exit");
        }

    }

    public void scaleUp()
    {
        productA.localScale = productBigSizeA;
        Debug.Log("scale up");
    }

    public void scaleDown()
    {
        productA.localScale = productSmallSizeA;
        Debug.Log("scale down");
    }
    void Update()
    {
        
    }
}
