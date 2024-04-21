using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletpos;
    private float timer;
    private GameObject Player;

    void Start()
    {

        Player = GameObject.FindGameObjectWithTag("player");
        
    }

    
    void Update()
    {
        float distance = Vector2.Distance(transform.position, Player.transform.position);
        Debug.Log(distance);
        if(distance<4)
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                timer = 0;
                shoot();

            }

        }

        

    }

    void shoot()
    {

        Instantiate(bullet, bulletpos.position, Quaternion.identity);
    }

}
