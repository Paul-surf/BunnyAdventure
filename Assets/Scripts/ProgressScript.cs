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
    public GameObject DoorBottom, Doortop, Lv3DoorTop, Lv3DoorBottom, Lv4DoorTop, lv2BLocker, Lv2BlockerTop,
    Lv4DoorBottom, WallBlockDoorTopBlockerLv3, WallBlockDoorBottomBlockerLv3, WallBlockDoorTopBackgroundLv3, 
    WallBlockDoorTopBlockerLv4, WallBlockDoorBottomBlockerLv4, WallBlockDoorTopBackgroundLv4, Sign3, Sign4;
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
        DoorTop3 = Lv3DoorTop.GetComponent<SpriteRenderer>();
        DoorMid3 = Lv3DoorBottom.GetComponent<SpriteRenderer>();
        DoorTop4 = Lv4DoorTop.GetComponent<SpriteRenderer>();
        DoorBottom4 = Lv4DoorBottom.GetComponent<SpriteRenderer>();
    }
    public void Update() {
        if (TotalProgress >= 2) {
            Lv2BlockerTop.SetActive(false);
            lv2BLocker.SetActive(false);
            TextMaker.LimitPlayerMovement = false;
            TimeLineHandler.SetActive(false);
            TimeLineHandler.SetActive(false);
            DoorTop2.sprite = DoorTop;
            DoorBottom2.sprite = DoorMid;
            WallBlockDoorTopBlockerLv3.SetActive(false);
            WallBlockDoorBottomBlockerLv3.SetActive(false);
            WallBlockDoorTopBackgroundLv3.SetActive(true);
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
            WallBlockDoorTopBlockerLv4.SetActive(false);
            WallBlockDoorBottomBlockerLv4.SetActive(false);
            WallBlockDoorTopBackgroundLv4.SetActive(true);
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