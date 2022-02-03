using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public Animator transition;

    void Start() {
    }

    public void PLAY() {
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene() {
        transition.SetBool("TransitionOut", true);
        yield return new WaitForSeconds(1.25f);
        SceneManager.LoadScene("MainHub", LoadSceneMode.Single);
    }

    public void HELP() {

    }

    public void QUIT() {
        Application.Quit();
    }

}
