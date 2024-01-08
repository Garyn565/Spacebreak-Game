using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossHealth : MonoBehaviour
{
    public float healthAmount1 = 150f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount1 == 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void TakeDamage(float damage)
    {
        healthAmount1 -= damage;
    }
}
