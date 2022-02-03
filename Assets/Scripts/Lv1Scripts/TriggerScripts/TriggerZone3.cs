using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone3 : MonoBehaviour
{
    public GameObject InteractiveText, CarrotText, Carrot, trigger;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
                InteractiveText.SetActive(false);
                CarrotText.SetActive(true);
                Carrot.SetActive(true);
            } 
    }

    private void OnTriggerExit2D() {
        trigger.SetActive(false);
    }
}
