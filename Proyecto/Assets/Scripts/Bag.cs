using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    int inventory = 0;

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Tool" && collision.gameObject.GetComponent<Tool>().GetPicked())
        {
            Destroy(collision.gameObject);
            inventory++;
        }
    }
}
