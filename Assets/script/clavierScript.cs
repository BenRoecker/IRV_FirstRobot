using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clavierScript : MonoBehaviour
{

    public materielScript materiel;
    public const float inc_step = 0.01f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 increment;
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            increment = new Vector3(0.0f, inc_step, 0.0f);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            increment = new Vector3(0.0f, -inc_step, 0.0f);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            increment = new Vector3(- inc_step, 0.0f, 0.0f);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            increment = new Vector3(inc_step, 0.0f, 0.0f);
        }
        else if (Input.GetKeyUp(KeyCode.Z))
        {
            increment = new Vector3(0.0f, 0.0f, inc_step);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            increment = new Vector3(0.0f, 0.0f,- inc_step);
        }
        else
        {
            increment = new Vector3(0.0f, 0.0f, 0.0f);
        }
        materiel.increment = increment;
    }
}
