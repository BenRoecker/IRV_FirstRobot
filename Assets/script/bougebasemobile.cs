using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bougebasemobile : MonoBehaviour
{
    public Vector3 increment_VR;
    public GameObject O0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(increment_VR.x, 0F, 0F);
        transform.Rotate(Vector3.up, increment_VR.y*100F);
    }
}
