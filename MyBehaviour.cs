using UnityEngine;
using System.Collections;

public class MyBehaviour : MonoBehaviour
{
    public static float maxHealth = 200;
    public static float healthP1 = 0;
    public static float healthP2 = 0;

    public static float pointsP1 = 0;    
    public static float pointsP2 = 0;

    public static int pl1 = 0;
    public static int pl2 = -1;

    public static int i;

    
    // Use this for initialization
    void Start()
    {
        healthP1 = maxHealth;
        healthP2 = maxHealth;
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 50, 50), "Menu"))
            Application.LoadLevel("menu");
    }
}
