using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class butttons : MonoBehaviour
{
    public KeyCode startgame;
    public KeyCode quitt;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(startgame))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKeyDown(quitt))
        {
            SceneManager.LoadScene("mainLevel");
        }
    }

}
