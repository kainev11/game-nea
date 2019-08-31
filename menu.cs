using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

    public int window;

	// Use this for initialization
	void Start () {
        window = 1;
	}
	
	void OnGUI()
    { 
        GUI.BeginGroup(new Rect(Screen.width / 2, Screen.height / 2-100, 200, 230));
        if (window == 1)
        {if (GUI.Button(new Rect(10, 30, 180, 30), "Play"))
            {
                window = 2;
            }
            
            if (GUI.Button(new Rect(10, 70, 180, 30), "Info"))
            {
                window = 3;
            }
            if (GUI.Button(new Rect(10, 110, 180, 30), "Quit"))
            {
                window = 4;
            }
            
        }
        if (window == 2)
            Application.LoadLevel("test scene");
        if(window==3)
        {
            GUI.Label(new Rect(10, 10, 100, 200), "Player1\n\n\n Base Attack: 1 \n\n Attack2: 2 \n\n Attack3: 3 \n\n Heal: 4");
            GUI.Label(new Rect(110, 10, 100, 200), "Player2 (NumLock)\n \nBase Attack: 1 \n\n Attack2: 2 \n\n Attack3: 3 \n\n Heal: 0");
            if (GUI.Button(new Rect(10, 200, 180, 30), "Back"))
                window = 1;
        }
        if (window == 4)
            Application.Quit();
        
        GUI.EndGroup();
    }
}
