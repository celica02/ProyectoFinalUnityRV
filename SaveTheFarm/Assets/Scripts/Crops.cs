using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crops : MonoBehaviour
{
    private Interactible i;
    // Start is called before the first frame update
    void Start()
    {
        i = gameObject.GetComponent<Interactible>();
        i.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length >
            gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime)
        {
            gameObject.GetComponent<Interactible>().enabled = true;
        }
    }
}
