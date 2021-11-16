using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toColor : MonoBehaviour
{
    // Start is called before the first frame update

    public bool estSelectionnable = false;
    void Start()
    {
        ToColor(Color.grey);
    }

    void ToColor(Color color)
    {
        transform.Find("Tcube").Find("cube").GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if (estSelectionnable)
        {
            ToColor(Color.red);
        }
        else
        {
            ToColor(Color.gray);
        }
    }
}
