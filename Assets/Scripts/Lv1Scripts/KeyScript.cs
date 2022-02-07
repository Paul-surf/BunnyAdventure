using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public int key;
    public GameObject FinalCourse;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            key += 1;
            FinalCourse.SetActive(true);
            Destroy(gameObject);
        }
    }
}