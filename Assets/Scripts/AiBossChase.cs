using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiBossChase : MonoBehaviour
{
    public GameObject BossFollow;
    public float speed;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        BossFollow = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        BossFollow = GameObject.FindWithTag("Player");

        distance = Vector2.Distance(transform.position, BossFollow.transform.position);
        Vector2 direction = BossFollow.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, BossFollow.transform.position, speed * Time.deltaTime);

    }
}
