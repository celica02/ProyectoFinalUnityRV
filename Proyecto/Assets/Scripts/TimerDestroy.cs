using System    .Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy : MonoBehaviour
{
    float timeToDestroy = 3,
          time = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= timeToDestroy)
        {
            Destroy(gameObject);
        }

    }
}
