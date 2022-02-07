using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Island;
    void OnTriggerEnter2D(Collider2D Collision) {
        if (Collision.tag == "Player") {
            Island.SetActive(true);
        }
    }
}
