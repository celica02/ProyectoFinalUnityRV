using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedsIntantiate : MonoBehaviour
{
    int maxSeeds = 6;
    float timer = 1, currentT = 1;
    GameObject seeds, obj;

    private void Start()
    {
        seeds = Resources.Load("Prefabs/Seeds") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        currentT -= Time.deltaTime;
        if (currentT <= 0)
        {
            int s = CountSeeds();
            if (s < maxSeeds)
            {
                obj = Instantiate(seeds);
                obj.transform.position = new Vector3(gameObject.transform.position.x,
                                                     gameObject.transform.position.y + 0.5f,
                                                     gameObject.transform.position.z);
            }
            currentT = timer;
        }
    }

    int CountSeeds()
    {
        var hits = Physics.OverlapSphere(this.transform.position, 1);
        int cont = 0;

        foreach (var c in hits)
        {
            if (c.CompareTag("Tool")) //use CompareTag, not tag ==
            {
                cont++;
            }
        }

        return cont;
    }
}
