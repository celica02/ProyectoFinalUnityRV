using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactible : MonoBehaviour
{
    private GameObject[] states = new GameObject[3];
    private int[] tools = new int[2];
    GameObject obj;
    int currentState = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Carga de Assets
        states[1] = Resources.Load("Prefabs/Hole") as GameObject;
        states[2] = Resources.Load("Prefabs/Dirt") as GameObject;

        tools[0] = tools[1] = 1;
        //Inicialización
        currentState = 0;
        if (states[currentState] != null)
            obj = Instantiate(states[currentState]);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Tool" &&
            currentState < tools.Length && 
            col.gameObject.GetComponent<Tool>().id == tools[currentState]
            )
        {
            if (obj != null)
                Destroy(obj);
            currentState++;
            if (states[currentState] != null)
            {
                obj = Instantiate(states[currentState]);
                obj.transform.position = new Vector3(gameObject.transform.position.x, 
                                                     obj.transform.position.y, 
                                                     gameObject.transform.position.z);
            }

        }
        //gameObject.GetComponent<Renderer>().material = b;
    }
}

