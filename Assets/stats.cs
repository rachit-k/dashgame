using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "score")
        {
            GetComponent<TextMesh>().text = "Score: " + gamemaster.scoreNow;
        }
        if(gameObject.name == "time")
        {
            GetComponent<TextMesh>().text = "Time: " + gamemaster.timeNow;
        }
        if(gameObject.name=="runstatus")
        {
            if (gamemaster.levelStat == 'p')
            {
                GetComponent<TextMesh>().text = "pass";
            }
            else
            {
                GetComponent<TextMesh>().text = "fail";
            }
        }
    }
}
