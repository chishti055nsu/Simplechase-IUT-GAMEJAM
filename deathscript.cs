using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathscript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject startpoint;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("player"))
        {

            player.transform.position = startpoint.transform.position;

        }

    }
}
