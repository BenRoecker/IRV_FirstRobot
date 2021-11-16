using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prendObjet : MonoBehaviour
{
    public GameObject O7tierce;
    public bool prendre = false;
    public selectionnableDistScript selectionnable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(prendre == false)
            {
                O7tierce.transform.Find("Opince_D").Find("pince_d").Translate( new  Vector3(0.0F, 0.015F, 0.0F));
                O7tierce.transform.Find("Opince_G").Find("pince_g").Translate(new Vector3(0.0F, -0.015F, 0.0F));
                prendre = true;
                if (selectionnable.toColor.estSelectionnable)
                {
                    selectionnable.transform.SetParent(O7tierce.transform.Find("Otool"));
                    selectionnable.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
            else
            {
                O7tierce.transform.Find("Opince_D").Find("pince_d").Translate(new Vector3(0.0F, -0.015F, 0.0F));
                O7tierce.transform.Find("Opince_G").Find("pince_g").Translate(new Vector3(0.0F, 0.015F, 0.0F));
                prendre = false;
                O7tierce.transform.Find("Otool").Find("Ocube").SetParent(null);
                selectionnable.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
        
    }
}
