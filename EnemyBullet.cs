using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public Rigidbody2D rb;
    public float force;
    private float timer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("player");
        Vector3 direction = Player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized*force;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>10)
        {
            Destroy(gameObject);

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            other.gameObject.GetComponent<health>().h -= 20;
            Destroy(gameObject);

        }

    }
}
