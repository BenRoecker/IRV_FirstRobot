using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sourisScript : MonoBehaviour
{
    public materielScript materiel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool B1 = false;
        bool B2 = false;
        bool B3 = false;
        if (Input.GetButtonDown("Fire1"))
        {
            B1 = true;
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            B2 = true;
        }
        else if (Input.GetButtonDown("Fire3"))
        {
            B3 = true;
        }
        materiel.B1 = B1;
        materiel.B2 = B2;
        materiel.B3 = B3;
    }
}
