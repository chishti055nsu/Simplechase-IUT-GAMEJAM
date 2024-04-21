
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    // Start is called before the first frame update
    public float h ;
    public float maxhealth;
    public Image healthBar;
  //  public GameManagerScript gameManager;
   // private bool isdead; 
    void Start()
    {
        maxhealth = h;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(h / maxhealth, 0, 1);
        if(h<=0 )
        {
            //isdead = true;
          //  gameManager.gameOver();
            Destroy(gameObject);
        }

        



    }
}
