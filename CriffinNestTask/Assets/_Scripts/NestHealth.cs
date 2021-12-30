using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestHealth : MonoBehaviour
{
    public static int maxHealth = 20;
    public int currentHealth;
    public GameObject GameOver, Restart;
    public HealthBar HealthBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        HealthBar.SetMaxHealth(maxHealth);
        GameOver.gameObject.SetActive(false);
        Restart.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Time.timeScale = 0;
            GameOver.gameObject.SetActive(true);
            Restart.gameObject.SetActive(true);

        }
        HealthBar.SetHealth(maxHealth);

    }
}
