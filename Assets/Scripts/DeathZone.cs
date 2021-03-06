using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject GameOverText;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            Destroy(collision.gameObject);
            GameOverText.SetActive(true);
        }
    }

}
