using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {
    static public int score = 1000;
	// Use this for initialization
	void Awake () {
		//if the ApplePickerHighScore already exists, read it
        if (PlayerPrefs.HasKey("ApplePickerHighscore"))
        {
            //assign the high score to ApplePickerHighscore
            PlayerPrefs.GetInt("ApplePickerHighscore");
        }
	}
	
	// Update is called once per frame
	void Update () {
        GUIText gt = this.GetComponent<GUIText>();
        gt.text = "High Score:  " + score;
		if (score > PlayerPrefs.GetInt("ApplePickerHighscore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighscore", score);
        }
	}
}
