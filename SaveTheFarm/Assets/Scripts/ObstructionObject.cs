using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstructionObject : MonoBehaviour
{
    public int toolID;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Tool" &&
            col.gameObject.GetComponent<Tool>().id == toolID
            )
        {
            Destroy(gameObject);
        }
    }
}
