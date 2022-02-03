using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTutorialText : MonoBehaviour
{
    public GameObject GameOverText, Text1, Text2, Text3;
    void Update()
    {
        if  (GameOverText.activeSelf == true) {
            Text1.SetActive(false);
        }
    }
}
