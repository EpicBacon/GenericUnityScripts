using UnityEngine;

public class ConsoleUI : MonoBehaviour {

    public static GUISkin skin;

    private static Rect pos;


    void Awake()
    {
        skin = skin ?? Resources.Load("Skin/skin") as GUISkin;
    }

    // Use this for initialization
    public void Start () {
        pos = new Rect(0.01f, 0.6f, 0.5f, 0.05f);
    }

    public void OnGUI()
    {
        GUI.skin = skin;
        float temp = pos.y;
        GUI.Label(new Rect(Screen.width * pos.x, (Screen.height * pos.y) - (Screen.height * pos.height) * 2, Screen.width * pos.width, Screen.height * pos.height), "<BaconConsole>", "console");
        GUI.Label(new Rect(Screen.width * pos.x, (Screen.height * pos.y) - Screen.height * pos.height, Screen.width * pos.width, Screen.height * pos.height), Screen.width + "/" + Screen.height, "console");
        foreach (string line in BaconConsole.Lines)
        {
            GUI.Label(new Rect(Screen.width * pos.x, Screen.height * pos.y, Screen.width * pos.width, Screen.height * pos.height), line, "console");
            pos.y += pos.height;
        }
        pos.y = temp;
    }
}
