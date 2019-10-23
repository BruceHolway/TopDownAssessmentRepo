using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TDMainMenu : MonoBehaviour
{
    public int lives = 5;
    public void Play()
    {
        SceneManager.LoadScene("TopDown");
        PlayerPrefs.SetInt("Lives", lives);
    }

    public void Quit()
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
