using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactible : MonoBehaviour
{
    private GameObject[] states = new GameObject[5];
    private GameObject wateredSoil;
    private int[] tools = new int[4];
    private int idWater = 3;
    GameObject obj;
    int currentState = 0;
    bool watered = false;


    // Start is called before the first frame update
    void Start()
    {
        //Carga de Assets
        states[0] = Resources.Load("Prefabs/weeds") as GameObject;
        //states[1] = Resources.Load("Prefabs/weeds") as GameObject;
        states[2] = Resources.Load("Prefabs/Hole") as GameObject;
        states[3] = Resources.Load("Prefabs/Dirt") as GameObject;
        states[4] = Resources.Load("Prefabs/Pumpkins_Growable") as GameObject;

        wateredSoil = Resources.Load("Prefabs/WateredSoil") as GameObject;

        tools[0] = tools[1] =  1;
        tools[2] = 2;
        tools[3] = 3;
        //Inicialización
        currentState = 0;
        if (states[currentState] != null)
        {
            obj = Instantiate(states[currentState]);
            obj.transform.position = new Vector3(gameObject.transform.position.x,
                                                     obj.transform.position.y,
                                                     gameObject.transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Tool")
        {
            if (currentState < tools.Length &&
               col.gameObject.GetComponent<Tool>().id == tools[currentState])
            {
                if (obj != null)
                    Destroy(obj);
                currentState++;
                if (states[currentState] != null)
                {
                    if (currentState == 3 && watered)
                        currentState++;

                    obj = Instantiate(states[currentState]);
                    obj.transform.position = new Vector3(gameObject.transform.position.x,
                                                         obj.transform.position.y,
                                                         gameObject.transform.position.z);

                    if (currentState == 4 && watered)
                        obj.GetComponent<Animator>().Play("Grow");
                }

            }
            else if (!watered && col.gameObject.GetComponent<Tool>().id == idWater)
            {
                wateredSoil = Instantiate(wateredSoil); //Se queda para siempre así, hay ver cuándo queremos que vuelva a estar seco.
                wateredSoil.transform.position = new Vector3(gameObject.transform.position.x,
                                                             wateredSoil.transform.position.y,
                                                             gameObject.transform.position.z);
                watered = true;
                if (currentState == 4)
                    obj.GetComponent<Animator>().Play("Grow");
            }


        }
    }
}

