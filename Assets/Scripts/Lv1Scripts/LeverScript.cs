using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    public Sprite ActivatedLever;
    public GameObject Island, sign;
    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.tag == "Player" && Input.GetKey(KeyCode.E)) {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ActivatedLever;
            StartCoroutine(AwaitFewMoments());
        }
    }
    IEnumerator AwaitFewMoments() {
        yield return new WaitForSeconds(0.8f);
        Island.SetActive(true);
        sign.SetActive(true);
    }
}
