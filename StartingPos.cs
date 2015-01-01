using UnityEngine;
using System.Collections;

public class StartingPos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.guiTexture.pixelInset = new Rect(Screen.width / 2 - guiTexture.pixelInset.width/2, Screen.height / 2 - guiTexture.pixelInset.height/2, 391, 250);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
