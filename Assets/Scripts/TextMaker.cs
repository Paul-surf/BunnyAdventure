using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMaker : MonoBehaviour {
   
    public Camera MainCamera, CutsceneCamera;
    public TextMeshProUGUI TextBox;
    private TextMeshProUGUI UIText;
    public GameObject TaleBubbel, Wingman;
    private string TextToWrite;
    private int CharacterIndex;
    private float TimePerCharacter;
    private float timer;
    public bool LimitPlayerMovement = true;

    private void Start() {
        TaleBubbel.SetActive(false);
        MainCamera.gameObject.SetActive(false);
        CutsceneCamera.gameObject.SetActive(true);
    }

    public void EnableBubble() {
        AddWriter(TextBox, " ", 0.08f);
        TaleBubbel.SetActive(true);
    }

    public void DisableBubble() {
        TaleBubbel.SetActive(false);
        AddWriter(TextBox, " ", 0.08f);
    }

    public void EnableCamera() {
        MainCamera.gameObject.SetActive(true);
        CutsceneCamera.gameObject.SetActive(false);
        Wingman.SetActive(false);
        LimitPlayerMovement = false;
    }

    public void FirstText() {
        AddWriter(TextBox, "Hello and Welcome! This is the Main Hub!", 0.08f);
    }

    public void SecondText() {
        AddWriter(TextBox, "From here you can travel to different levels to complete their respective challenges!", 0.08f);
    }

    public void ThirdText() {
        AddWriter(TextBox, "This is a warp door! You use these doors to travel to the different levels!", 0.08f);
    }

    public void FourthText() {
        AddWriter(TextBox, "The warp door to the next level, will unlock after completing the previous one!", 0.08f);
    }

    public void FifthText() {
        AddWriter(TextBox, "That was all I had for now! You can start by heading to the first level! See ya!", 0.08f);
    }

    public void AddWriter(TextMeshProUGUI UIText, string TextToWrite, float TimePerCharacter) {
        CharacterIndex = 0;
        this.UIText = UIText;
        this.TextToWrite = TextToWrite;
        this.TimePerCharacter = TimePerCharacter;
    }

    private void Update() {
        if(UIText != null) {
            timer -= Time.deltaTime;
            if(timer <= 0f) {
                timer += TimePerCharacter;
                CharacterIndex++;
                if(CharacterIndex <= TextToWrite.Length) {
                    UIText.text = TextToWrite.Substring(0, CharacterIndex);
                }
            }
        }
    }
}
