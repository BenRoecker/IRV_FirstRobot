using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineEtatScript : MonoBehaviour
{
    public selectionScript selection;
    public navigationScript navigation;
    public camera_controller camera;
    public materielScript materiel;
    public selectionnableDistScript selectionnable;
    public string isInNavigation = "Navigation";
    // Start is called before the first frame update
    void Start()
    {
        isInNavigation = "Navigation";
    }


    // Update is called once per frame
    void Update()
    {
        if (materiel.B2)
        {
            if(isInNavigation == "Navigation")
            {
                isInNavigation = "Selection";
            }
            else if(isInNavigation == "Selection")
            {
                isInNavigation = "Camera";
            }
            else
            {
                isInNavigation = "Navigation";
            }
        }
        if (isInNavigation == "Navigation")
        {
            navigation.increment_IR = materiel.increment;
        }
        else if (isInNavigation == "Selection")
        {
            selection.increment = materiel.increment;
        }
        else if (isInNavigation == "Camera")
        {
            camera.B1 = materiel.B1;   
        }
    }
}
