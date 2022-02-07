using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{
    public KeyScript KeyCount;
    public GameObject island, door;
    void Update() {
        if (KeyCount.key >= 1) {
            // Debug.Log("current got " + KeyCount.key + "keys");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (KeyCount.key >= 1 && collision.tag == "Player") {
            ProgressScript.TotalProgress += 1;
            KeyCount.key -= 1;
            island.SetActive(true);
            door.SetActive(true);
            Destroy(gameObject);
        }
    }
}
