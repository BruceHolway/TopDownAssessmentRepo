using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TDPlayerHP : MonoBehaviour
{
    public int health = 10;
    public Text healthText;
    public Slider healthSlider;

    private void Start()
    {
        healthText.text = "HP: " + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "HP: " + health;
            healthSlider.value = health;
            //same as health -= 1, or health = health -1
            if (health < 1)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
