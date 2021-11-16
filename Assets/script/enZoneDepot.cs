using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enZoneDepot : MonoBehaviour
{
    // Start is called before the first frame update
    public bool zoned;
    public GameObject Depot;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == Depot.GetComponent<Collider>())
        {
            zoned = true;
        }
    }
    // Update is called once per frame
    void Update()
    { 
    }
}
