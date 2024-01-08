using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab = null;
    [SerializeField] private float fireDelayTime = 0.1f;
    public Transform firePoint;

    private float fireCounter = 0.0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && fireCounter <= 0.0f)
        {
            // Fire pressed and counter <=0 so okay to create bullet and reset counter to fire delay time
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.Euler(0, 0, firePoint.eulerAngles.z));
            fireCounter = fireDelayTime;
        }
        else
        {
            // Decrease fireCounter by time elapsed since the last frame - even if fire pressed we'll not create a bullet since fireCounter needs to be <= 0 for this to happen.
            fireCounter -= Time.deltaTime;
        }
    }
}