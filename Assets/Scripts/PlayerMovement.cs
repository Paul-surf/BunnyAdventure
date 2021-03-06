using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public TextMaker TextMaker;
    private Rigidbody2D RB;
    private Animator anim;
    private float speed = 500;
    private float JumpPower = 500;
    private float _startJumpPower;
    private float _startSpeed;
    public bool CanJump = true;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        _startSpeed = speed;
        _startJumpPower = JumpPower;
    }
    void Update()
    {
        if(TextMaker.LimitPlayerMovement == false) {
            Vector2 movement = new Vector2(0, RB.velocity.y);

            if (Input.GetKey(KeyCode.A)) {
                movement.x = -speed*Time.deltaTime;
                anim.SetFloat("Vertical", -1);
            } else if (Input.GetKey(KeyCode.D)) {
                movement.x = speed*Time.deltaTime;
                anim.SetFloat("Vertical", 1);
            } else {
                anim.SetFloat("Vertical", 0);
            }
            if (Input.GetKeyDown(KeyCode.W)) {
                StartCoroutine(SingleJump());
            }

            RB.velocity = movement;
        }
    }

    public void JumpPowerUp(float seconds, float Power) {
        StartCoroutine(RunJumpPowerUp(seconds, Power));
    }

    IEnumerator RunJumpPowerUp(float seconds, float Power) {
        JumpPower = Power;
        yield return new WaitForSeconds(seconds);
        JumpPower = _startJumpPower;
    }

    public void SpeedPowerup(float sec, float sPower) {
        StartCoroutine(RunSpeedBoost(sec, sPower));
    }

    IEnumerator RunSpeedBoost(float seconds, float speedPower) {
        speed = speedPower;
        yield return new WaitForSeconds(seconds);
        speed = _startSpeed;
    }

    IEnumerator SingleJump() {
        if(RB.velocity.y < 0.05 && RB.velocity.y > -0.05) {
            CanJump = true;
        } else {
            CanJump = false;
        }
        if(CanJump == true) {
            RB.AddForce(new Vector2(0, JumpPower));
        }
        yield return null;
    }

    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.tag == "Lvl1" &&  transform.position.x < -8.61-3.72f) {
            RB.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX;
            transform.position = new Vector2(-8.61f - 3.72f, -0.3237126f - 3.54f);
            anim.SetBool("EnterLevel", true);
            StartCoroutine(AnimationWait());
        }
        if (collision.tag == "Lvl2" && ProgressScript.TotalProgress >= 2) {
            anim.SetBool("EnterLevel", true);
            StartCoroutine(AnimationWait2());
        }
        if (collision.tag == "Lvl3" && ProgressScript.TotalProgress >= 3) {
            anim.SetBool("EnterLevel", true);
            StartCoroutine(AnimationWait3());
        }
        if (collision.tag == "Lvl4" && ProgressScript.TotalProgress >= 4) {
            anim.SetBool("EnterLevel", true);
            StartCoroutine(AnimationWait4());
        }
    }

    IEnumerator AnimationWait() {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(2, LoadSceneMode.Single);
        ProgressScript.TotalProgress += 1;
    }

    IEnumerator AnimationWait2()  {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }
    IEnumerator AnimationWait3() {
        yield return new WaitForSeconds(0.8f); 
        SceneManager.LoadScene(4, LoadSceneMode.Single);
    }
    IEnumerator AnimationWait4() {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(5, LoadSceneMode.Single);
    }
}
