using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        GameObject o = Instantiate(obj);
        o.transform.position = gameObject.transform.position;
    }
}
