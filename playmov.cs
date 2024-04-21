using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playmov : MonoBehaviour
{
    // Start is called before the first frame update
    public float jump;
    public float speed;
    private float move;
    public Rigidbody2D rb;
    public bool IsJump;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);

        if (Input.GetButton("Jump") && IsJump == false)
        {

            rb.AddForce(new Vector2(rb.velocity.x, jump));

        }


    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Square"))
        {

            IsJump = false;

        }

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Square"))

        {

            IsJump = true;
        }
    }
}
