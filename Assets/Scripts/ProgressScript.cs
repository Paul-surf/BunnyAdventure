using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ProgressScript : MonoBehaviour
{
    public static int TotalProgress = 0;
    public PlayableDirector playableDirector;
    public GameObject TimeLineHandler;
    public Sprite DoorMid, DoorTop;
    SpriteRenderer DoorTop2, DoorBottom2;
    public GameObject DoorBottom, Doortop;
    public TextMaker TextMaker;
    void Awake() {
        if (TotalProgress <= 1) {
            TimeLineHandler.SetActive(true);
            playableDirector.Play();
        }
    }
    void Start() {
        DoorTop2 = Doortop.GetComponent<SpriteRenderer>();
        DoorBottom2 = DoorBottom.GetComponent<SpriteRenderer>();
        TotalProgress += 1;
    }
    public void Update() {
        // if (TotalProgress <= 1) {
        //     TimeLineHandler.SetActive(true);
        //     playableDirector.Play();
        //     TotalProgress += 1;
        // }
        if (TotalProgress >= 2) {
            TextMaker.LimitPlayerMovement = false;
            TimeLineHandler.SetActive(false);
            TimeLineHandler.SetActive(false);
            DoorTop2.sprite = DoorTop;
            DoorBottom2.sprite = DoorMid;
        }
    }
}
