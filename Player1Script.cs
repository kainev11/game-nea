using UnityEngine;
using System.Collections;
using System.Security.Cryptography;


public class Player1Script : MyBehaviour 
{
    private Animator anim;

    public Texture2D textrH1;
    public Texture2D textrP1;

    public Texture2D maskH1;
    public Texture2D maskP1;

    
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthP1 <= 0)
            Destroy(this.gameObject);
        if (healthP1 > maxHealth)
            healthP1 = maxHealth;

        if (pl1 != -1 && Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.Play("AttackF1");
            pl1++;
            i = Random.Range(1, 6);
            healthP2 -= i;                
        }

        if (pl1 == 0)
        {
            if (pointsP1 > 1 && Input.GetKeyDown(KeyCode.Alpha2))
            {
                anim.Play("AttackF2");
                pl1 = 5;
                i = Random.Range(15, 26);
                pointsP1 -= 2;
                healthP2 -= i;
            }

            if (pointsP1 == 3 && Input.GetKeyDown(KeyCode.Alpha3))
            {
                anim.Play("AttackF3");
                pl1 = 5;
                i = Random.Range(25, 36);
                pointsP1 = 0;
                healthP2 -= i;
            }
            if (pointsP1 != 0 && Input.GetKeyDown(KeyCode.Alpha4))
            {
                pl1 = 5;
                i = Random.Range(10, 20);
                pointsP1--;
                healthP1 += i;
            }
        }

        if (pl1 == 5)
        {
            if (pointsP1 < 3) 
                pointsP1++;
            pl1 = -1;
            pl2 = 0;
        }
        
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(20, Screen.height-25, Screen.width/3*(healthP1/maxHealth), 20 ), textrH1);
        GUI.DrawTexture(new Rect(15, Screen.height - 60, (Screen.width / 6+10) *(pointsP1/3), 20), textrP1);
        GUI.DrawTexture(new Rect(0, Screen.height-30, Screen.width/3+40, 30), maskH1);
        GUI.DrawTexture(new Rect(0, Screen.height -65, Screen.width/6+40,30), maskP1);
    }

   
}


