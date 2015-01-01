	using UnityEngine;
using System.Collections;

public class ExitHandler : MonoBehaviour {
	
	public bool onMenu;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			if(onMenu)
				Application.Quit();
			else
				//game.Echap();
			    Application.LoadLevel("Menu"); 
		}
	}
}
