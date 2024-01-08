using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletController : MonoBehaviour
{
    public GameObject enemy;
    public float speed = 8.0f;
    [SerializeField] private float destroyTime = 1.0f;

    private void Start()
    {
        StartCoroutine(DestroyBullet());
        enemy = GameObject.FindGameObjectWithTag("Player");
        // Set the initial velocity based on the bullet's rotation
        Vector2 direction = transform.up;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bullet collides with an object tagged as "Wall"
        if (other.CompareTag("Wall"))
        {
            Destroy(this.gameObject);

        }
        else if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Debug.Log("Player hit");
            enemy.GetComponent<EnemyHealth>().TakeDamage(25);
        }
    }
}