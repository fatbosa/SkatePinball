using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{
    public static int pont = 0;
    public Text soma;

    void Update()
    {
        pont = ballMovement.score;
        soma.text = "Score: " + pont.ToString();
    }
}