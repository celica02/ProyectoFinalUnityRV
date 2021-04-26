using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    float movementTime = 2,
          moving = 0;
    bool up = true;
    // Update is called once per frame
    void Update()
    {
        moving += Time.deltaTime;
        if (moving >= movementTime)
        {
            up = !up;
            moving = 0;
        }
        if (up)
            transform.Translate(Vector3.up * Time.deltaTime);
        else
            transform.Translate(Vector3.down * Time.deltaTime);
    }

    public void DestroyText()
    {
        Destroy(gameObject);
    }
}
