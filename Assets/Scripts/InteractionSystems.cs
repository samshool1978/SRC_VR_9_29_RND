using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystems : MonoBehaviour
{
    [Header("Large Aircrafts")]
    public GameObject F35;
    public GameObject C17;
    public GameObject C53;
    public GameObject Archer;

    public void C53_Activate()
    {
        C53.SetActive(true);

        C17.SetActive(false);
        Archer.SetActive(false);
        F35.SetActive(false);
    }


    public void C17_Activate()
    {
        C17.SetActive(true);

        C53.SetActive(false);
        Archer.SetActive(false);
        F35.SetActive(false);
    }

    public void Archer_Activate()
    {
        Archer.SetActive(true);

        C53.SetActive(false);
        C17.SetActive(false);
        F35.SetActive(false);
    }

    public void F35_Activate()
    {
        F35.SetActive(true);

        Archer.SetActive(false);
        C53.SetActive(false);
        C17.SetActive(false);
    }


    void Update()
    {
        
    }
}
