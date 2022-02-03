using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneScripts : MonoBehaviour
{
   public GameObject AWDtext, SuperJumpText, trigger;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
                AWDtext.SetActive(false);
                SuperJumpText.SetActive(true);
            } 
    }

    private void OnTriggerExit2D() {
        trigger.SetActive(false);
    }

}