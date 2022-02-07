using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ProgressScript : MonoBehaviour
{
    public static int TotalProgress = 0;
    public PlayableDirector playableDirector;
    public GameObject TimeLineHandler;
    public Sprite DoorMid, DoorTop, Doormid3, Doortop3, Doortop4, Doorbottom4;
    SpriteRenderer DoorTop2, DoorBottom2, DoorMid3, DoorTop3, DoorTop4, DoorBottom4;
    public GameObject DoorBottom, Doortop, Lv3DoorTop, Lv3DoorBottom, Lv4DoorTop, Lv4DoorBottom, WallBlock1, WallBlock2, Wallblock3, WallBlock4, Sign3, Sign4;
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
        if (TotalProgress >= 2) {
            TextMaker.LimitPlayerMovement = false;
            TimeLineHandler.SetActive(false);
            TimeLineHandler.SetActive(false);
            DoorTop2.sprite = DoorTop;
            DoorBottom2.sprite = DoorMid;
            WallBlock1.SetActive(false);
            WallBlock2.SetActive(false);
            Lv3DoorTop.SetActive(true);
            Lv3DoorBottom.SetActive(true);
            Sign3.SetActive(true);
        }
        if (TotalProgress >= 3) {
            DoorMid3.sprite = Doormid3;
            DoorTop3.sprite = Doortop3;
            Sign4.SetActive(true);
            Lv4DoorTop.SetActive(true);
            Lv4DoorBottom.SetActive(true);
            Wallblock3.SetActive(false);
            WallBlock4.SetActive(false);
        }
        if (TotalProgress >= 4) {
            DoorBottom4.sprite = Doorbottom4;
            DoorTop3.sprite = Doortop4;
        }
        if (TotalProgress >= 5) {
            TextMaker.LimitPlayerMovement = true;
            // Tell the player they completed the game!
        }
    }
}