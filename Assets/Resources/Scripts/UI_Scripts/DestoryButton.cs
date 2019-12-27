using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryButton : MonoBehaviour {
	public GameObject DestoryTarget;

	public void OnClick(){
		Destroy(DestoryTarget);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
