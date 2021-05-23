using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingBox : MonoBehaviour
{
    public GameObject[] tomatos;
    int idT = 0;

    private void Start()
    {
        foreach (GameObject t in tomatos)
        {
            t.SetActive(false);
        }
    }

    public void TomatosCollected()
    {
        tomatos[idT].SetActive(true);
        if (idT < tomatos.Length - 1)
            idT++;
    }

}
