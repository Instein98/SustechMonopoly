using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingWindow : MonoBehaviour {
	public UISlider slider;
	public void change(){
		GlobalControl.volume = slider.value;
		GlobalControl.setVolume();
	}
	// Use this for initialization
	void Start () {
		slider.value = GlobalControl.volume;
		GameController.hasUI = true;
	}

	public void setHasUI(){
		GameController.hasUI = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
