using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maxScore : MonoBehaviour
{
    public static int maxPont = 0;
    public Text soma;

    void Update()
    {
        maxPont = ballMovement.maxScore;
        soma.text = "Max score: " + maxPont.ToString();
    }
}
