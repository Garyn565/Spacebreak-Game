using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiChase : MonoBehaviour
{
    public GameObject EnemyFollow;
    public float speed;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        EnemyFollow = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
                EnemyFollow = GameObject.FindWithTag("Player");

        distance = Vector2.Distance(transform.position, EnemyFollow.transform.position);
        Vector2 direction = EnemyFollow.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, EnemyFollow.transform.position, speed * Time.deltaTime);

    }
}
