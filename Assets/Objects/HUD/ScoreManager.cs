﻿using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	private Text text;
	// Use this for initialization
	void Start (){
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update (){
		text.text = SonicEngine.Base.Score.ToString();
	}
}