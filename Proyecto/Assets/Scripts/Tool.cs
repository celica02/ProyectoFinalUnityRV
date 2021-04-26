using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    bool picked = false;
    
    public void SetPicked(bool p) { picked =p; }
    public bool GetPicked() { return picked; }
}
