using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[ExecuteInEditMode]

public class Console : MonoBehaviour {
	
	private List<string>		lines;
	private Rect				pos;
	private	int					maxline = 4;
	public	GUISkin				skin;

    void Awake() {
        lines = new List<string>();    
    
    }

	// Use this for initialization
	void Start () {
        skin = skin ?? Resources.Load("Skin/skin") as GUISkin;

		pos = new Rect(0.01f, 0.6f, 0.5f, 0.05f); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}	
	
	void	 OnGUI()
	{
		GUI.skin = skin;
		float	temp = pos.y;
        GUI.Label(new Rect(Screen.width * pos.x, (Screen.height * pos.y) - (Screen.height * pos.height) * 2, Screen.width * pos.width, Screen.height * pos.height), "<ShootemConsole>", "console");
        GUI.Label(new Rect(Screen.width * pos.x, (Screen.height * pos.y) - Screen.height * pos.height, Screen.width * pos.width, Screen.height * pos.height), Screen.width + "/" + Screen.height, "console");
        foreach (string line in lines)
		{
            GUI.Label(new Rect(Screen.width * pos.x, Screen.height * pos.y, Screen.width * pos.width, Screen.height * pos.height), line, "console");
            pos.y += pos.height;		
		}
		pos.y = temp;
		
	}
	
	public void 	WriteLine(string toadd)
	{
        if (lines != null)
		lines.Add(toadd);
        Debug.Log("ConsoleIG: " + toadd);
		if (lines.Count > maxline)
			lines.RemoveAt(0);
	}
	
	
	
}
