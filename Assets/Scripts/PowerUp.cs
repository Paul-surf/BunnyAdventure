using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public float JumpPowerDuration = 3;
    public float JumpPowerAmount = 800;

    void Start() {   
    }

    void Update() {   
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            collision.GetComponent<playermovementInLevels>().JumpPowerUp(JumpPowerDuration, JumpPowerAmount);
            Destroy(gameObject);
        }
    }

}
 