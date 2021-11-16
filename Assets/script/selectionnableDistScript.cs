using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectionnableDistScript : MonoBehaviour
{
    public toColor toColor;
    public GameObject Otool;
    public float distanceMin = 0.05F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.LogError(other.name);
        if (other == Otool.GetComponent<Collider>())
        {
            toColor.estSelectionnable = true;
        }
        else
        {
            toColor.estSelectionnable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
