using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemaster : MonoBehaviour
{
    public static float zVel = 4;
    public static float yVel= 0.0f ;

    public static int scoreNow = 0;
    public static float timeNow = 0;

    public static float waitTime = 0;

    public static char levelStat = ' ';

    public float zScenePos =28;

    public Transform bb;
    public Transform coinObj;

    public int randNo1;
   

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bb, new Vector3(0, 3.5f, 26), bb.rotation);
        //while(zScenePos<150)
        //{
        //    Instantiate(bb, new Vector3(0, 3.5f, zScenePos), bb.rotation);
        //    zScenePos = zScenePos + 2;
        //}
    }

    // Update is called once per frame
    void Update()
    {
       if(zScenePos < 150)
        {
            Instantiate(bb, new Vector3(0, 3.5f, zScenePos), bb.rotation);
            zScenePos = zScenePos + 2;

            randNo1 = Random.Range(0, 9);
            if(randNo1==0)
            {
                Instantiate(coinObj, new Vector3(0, 4.5f, zScenePos), coinObj.rotation);
            }
            if (randNo1 == 1)
            {
                Instantiate(coinObj, new Vector3(1, 4.5f, zScenePos), coinObj.rotation);
            }
            if (randNo1 == 2)
            {
                Instantiate(coinObj, new Vector3(-1, 4.5f, zScenePos), coinObj.rotation);
            }
        }

        timeNow = timeNow + Time.deltaTime;

        if(levelStat=='f')
        {
            waitTime = waitTime + Time.deltaTime;

        }
        if(waitTime>2)
        {
            SceneManager.LoadScene("mainLevel");
        }
    }
}
