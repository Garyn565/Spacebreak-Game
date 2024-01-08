using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyBullet : MonoBehaviour

{
    public GameObject player;
    private Rigidbody2D rb;
    public float force;
    public float timer;
    private Vector3 direction;
    public LayerMask playerLayer;
    // Start is called before the first frame update 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        direction = player.transform.position - transform.position;
        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }



    // Update is called once per frame 

    void Update()
    {
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        timer += Time.deltaTime;
        if (timer > 10)
        {
            Debug.Log("bullet destroy no hit");
            Destroy(gameObject);
        }
    }
    //    void OnCollisionEnter2D(Collision2D other)
    //    {
    //        if (other.gameObject.CompareTag("Player"));
    //        {
    //            Debug.Log("bullet destroy hit player");
    //            Destroy(gameObject);
    //            player.GetComponent<PlayerHealth>().TakeDamage(20);
    //        }
    //        if (other.CompareTag("Wall"));
    //        {
    //            Debug.Log("bullet destroy hit wall");
    //            Destroy(gameObject);
    //        }
    //    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(20);
            Destroy(gameObject); // Destroy the bullet after hitting the player
        }
    }
}
