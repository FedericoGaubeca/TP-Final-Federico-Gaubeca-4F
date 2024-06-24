using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectorDeObjetos : MonoBehaviour
{
    public GameObject[] obj;
    public int CurrentObjectIndex = -1;

    void Start()
    {
        DeactivteObjetos();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActivateAcendingObject();
        }
        else if ((Input.GetKeyDown(KeyCode.RightArrow)))
        {
            ActivateDecendingObject();
        }
    }


    void ActivateAcendingObject()
    {
        CurrentObjectIndex++;

        if (CurrentObjectIndex >= obj.Length)
        {
            CurrentObjectIndex = 0;
        }
        DeactivteObjetos();
        obj[CurrentObjectIndex].SetActive(true);
    }
    void ActivateDecendingObject()
    {
        CurrentObjectIndex--;
        if (CurrentObjectIndex < 0)
        {
            CurrentObjectIndex = obj.Length - 1;
        }
        DeactivteObjetos();
        obj[CurrentObjectIndex].SetActive(true);
    }

    void DeactivteObjetos()
    {
        foreach (GameObject g in obj)
        {
            g.SetActive(false);
        }
    }
}


