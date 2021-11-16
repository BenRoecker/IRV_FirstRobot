using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigationScript : MonoBehaviour
{
    public bougebasemobile bougebasemobile;
    public Vector3 increment_IR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bougebasemobile.increment_VR = new Vector3(increment_IR.y, increment_IR.x, 0F);
    }
}
