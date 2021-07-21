using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlePalhetaD : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var hinge = GetComponent<HingeJoint>();

        if(Input.GetButton("palhetaDireita")){
            hinge.useMotor = true;
        }
        else{
            hinge.useMotor = false;
        }

    }
}
