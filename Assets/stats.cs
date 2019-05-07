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
        if (gameObject.name == "finalscore")
        {
            GetComponent<TextMesh>().text = "SCORE: " + (gamemaster.scoreNow - (300 - gamemaster.timeNow));
        }
        if (gameObject.name == "score")
        {
            GetComponent<TextMesh>().text = "SCORE: " + gamemaster.scoreNow;
        }
        if (gameObject.name == "time")
        {
            GetComponent<TextMesh>().text = "TIME LEFT : " + (300-gamemaster.timeNow);
        }
        if (gameObject.name == "distleft")
        {
            GetComponent<TextMesh>().text = "DIST LEFT: " + gamemaster.distleftNow;
        }
        if (gameObject.name=="runstatus")
        {
            if (gamemaster.levelStat == 'p')
            {
                GetComponent<TextMesh>().text = "CONGRATS, YOU PASSED";
            }
            else
            {
                GetComponent<TextMesh>().text = "AWW, BETTER LUCK NEXT TIME";
            }
        }
    }
}
