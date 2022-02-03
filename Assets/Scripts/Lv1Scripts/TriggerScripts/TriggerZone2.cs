using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone2 : MonoBehaviour
{
    public GameObject SuperJumpText, InteractiveText, trigger;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
                SuperJumpText.SetActive(false);
                InteractiveText.SetActive(true);
            } 
    }

    private void OnTriggerExit2D() {
         trigger.SetActive(false);
    }
}
