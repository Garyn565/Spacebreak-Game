using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Import the SceneManager

public class PlayerHealth : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            // If health is zero or less, load the main menu scene
            SceneManager.LoadScene(0);
        }
        else // If health is greater than 0, continue with other functionalities
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                Heal(5);
            }
        }
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }
}