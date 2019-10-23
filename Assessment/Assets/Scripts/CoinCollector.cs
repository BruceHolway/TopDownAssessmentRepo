using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public int coinCount = 0;
    public Text coinText;
    void Start()
    {
        coinText.text = "Coins: " + coinCount;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            coinCount++;
            coinText.text = "Coins: " + coinCount;
            Destroy(collision.gameObject);
            if(coinCount > 30)
            {
                SceneManager.LoadScene("Victory");
            }
        }
    }
}
