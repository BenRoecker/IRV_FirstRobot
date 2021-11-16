using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genere : MonoBehaviour
{
    public GameObject original;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vector = new Vector3();
        for(int i = 0;i < 10; i++)
        {
            vector = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            GameObject clone = Instantiate(original, vector, new Quaternion());
            clone.name = "Cube" + i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
