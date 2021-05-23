using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatosColected : MonoBehaviour
{

    public Material transparentMat, redMat;
    Material[] mats;
    bool tomatos = true;
    float time = 5, timeToGrow;

    // Start is called before the first frame update
    void Start()
    {
        mats = gameObject.GetComponent<Renderer>().materials;
        mats[0] = redMat;

        for (int i = 0; i < mats.Length; i++)
        {

            Debug.Log(mats[i]);
        }

    }
    public bool hasTomatos()
    {
        return tomatos;
    }

    void Colect()
    {
        mats[0] = transparentMat;
        gameObject.GetComponent<Renderer>().materials = mats;
        timeToGrow = time;
        tomatos = false;
        Debug.Log("Colect");
    }

    void Grow()
    {
        mats[0] = redMat;
        gameObject.GetComponent<Renderer>().materials = mats;
        tomatos = true;
        Debug.Log("Grow");

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Tool>().id == 4)
        {
            if (tomatos)
                Colect();
            col.gameObject.GetComponent<CollectingBox>().TomatosCollected();
        }
    }

    private void Update()
    {
        if (timeToGrow > 0)
            timeToGrow -= Time.deltaTime;
        else if (!tomatos)
            Grow();
    }
}
