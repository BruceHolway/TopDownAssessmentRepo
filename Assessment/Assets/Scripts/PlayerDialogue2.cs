using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDialogue2 : MonoBehaviour
{
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 7)
        {
            GetComponent<Text>().enabled = true;
        }
        if(timer > 12)
        {
            GetComponent<Text>().enabled = false;
        }
    }
}
