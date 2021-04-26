using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColocated : MonoBehaviour
{
    public GameObject text;
    public GameObject[] boxes;

    public int nObjects = 0;

    void Start()
    {
        boxes = GameObject.FindGameObjectsWithTag("Box");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Box")
        {
            nObjects++;
            if (nObjects >= boxes.Length)
            {
                text.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        nObjects--;
    }
}
