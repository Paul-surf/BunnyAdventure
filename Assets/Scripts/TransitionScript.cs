using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TransitionScript : MonoBehaviour
{
   
    public TextMaker TypeWriter;
    public TextMeshProUGUI TextWriter;
    public Animator transition;
    public GameObject Talebobbel;

    void Start() {
        StartCoroutine(TransitionIn());
    }

    IEnumerator TransitionIn() {
        transition.SetBool("TransitionIn", true);
        yield return new WaitForSeconds(1.25f);
        transition.SetBool("TransitionIn", false);
    }
}
