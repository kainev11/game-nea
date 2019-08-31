using UnityEngine;
using System.Collections;

public class Player2Script : MyBehaviour
{
    private Animator anim;

    public Texture2D textrH2;
    public Texture2D textrP2;

    public Texture2D maskH2;
    public Texture2D maskP2;
    // Use this for initialization
    void Start ()
    { 
    anim = GetComponent<Animator>();

	    }
	
	// Update is called once per frame
	void Update () {    
        if (healthP2 <= 0)
            Destroy(this.gameObject);
        if (healthP2 > maxHealth)
            healthP2 = maxHealth;
        if (pl2 != -1 && Input.GetKeyDown(KeyCode.End))
        {
            anim.Play("AttackM1");
            pl2++;
            i = Random.Range(1, 6);
            healthP1 -= i;            
        }

        if (pl2 == 0)
        {
            if (pointsP2 > 1 && Input.GetKeyDown(KeyCode.DownArrow))
            {
                pl2 = 5;
                anim.Play("AttackM2");
                i = Random.Range(15, 26);
                pointsP2 -= 2;
                healthP1 -= i;
            }

            if (pointsP2 == 3 && Input.GetKeyDown(KeyCode.PageDown))
            {
                pl2 = 5;
                anim.Play("AttackM3");
                i = Random.Range(25, 36);
                pointsP2 = 0;
                healthP1 -= i;
            }
            if (pointsP2 != 0 && Input.GetKeyDown(KeyCode.Insert))
            {
                pl2 = 5;
                i = Random.Range(10, 20);
                pointsP2--;
                healthP2 += i;
            }
        }

        if (pl2 == 5)
        {
            if (pointsP2 < 3)
                pointsP2++;
            pl2 = -1;
            pl1 = 0;
        }

    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width-20, Screen.height - 25,
            -Screen.width / 3 * (healthP2 / maxHealth), 20), textrH2);
        GUI.DrawTexture(new Rect(Screen.width-15, Screen.height - 60,
            -(Screen.width / 6 + 10) * (pointsP2 / 3), 20), textrP2);
        GUI.DrawTexture(new Rect(Screen.width-(Screen.width / 3 + 40),
            Screen.height - 30, Screen.width / 3 + 40, 30), maskH2);
        GUI.DrawTexture(new Rect(Screen.width-(Screen.width / 6 + 40),
            Screen.height - 65, Screen.width / 6 + 40, 30), maskP2);
    }
}
