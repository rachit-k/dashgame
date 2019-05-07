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
    public static float distleftNow = 250;

    public static float waitTime = 0;

    public static char levelStat = ' ';

    public static float zScenePos =0;

    public Transform Block;
    public Transform man1;
    public Transform girl1;
    public Transform oldman;
    public Transform man2;
    public Transform girl2;
    public Transform garbage;
    public Transform car;

    public static int randNo1;
   

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Block, new Vector3(0, 0, 8), Block.rotation);
        //while(zScenePos<150)
        //{
        //    Instantiate(bb, new Vector3(0, 3.5f, zScenePos), bb.rotation);
        //    zScenePos = zScenePos + 2;
        //}
    }

    // Update is called once per frame
    void Update()
    {
       if(zScenePos < 500)
        {
            Instantiate(Block, new Vector3(0, 0, zScenePos), Block.rotation);
            zScenePos = zScenePos + 2;

            randNo1 = Random.Range(0, 20);
            if(randNo1==0)
            {
                Instantiate(oldman, new Vector3(0, 0.5f, zScenePos), oldman.rotation);
            }
            if (randNo1 == 1)
            {
                Instantiate(oldman, new Vector3(1, 0.5f, zScenePos), oldman.rotation);
            }
            if (randNo1 == 2)
            {
                Instantiate(oldman, new Vector3(2, 0.5f, zScenePos), oldman.rotation);
            }

            if (randNo1 == 3)
            {
                Instantiate(man1, new Vector3(0, 0.5f, zScenePos), man1.rotation);
            }
            if (randNo1 == 4)
            {
                Instantiate(man1, new Vector3(1, 0.5f, zScenePos), man1.rotation);
            }
            if (randNo1 == 5)
            {
                Instantiate(man1, new Vector3(2, 0.5f, zScenePos), man1.rotation);
            }

            if (randNo1 == 6)
            {
                Instantiate(man2, new Vector3(0, 0.5f, zScenePos), man2.rotation);
            }
            if (randNo1 == 7)
            {
                Instantiate(man2, new Vector3(1, 0.5f, zScenePos), man2.rotation);
            }
            if (randNo1 == 8)
            {
                Instantiate(man2, new Vector3(2, 0.5f, zScenePos), man2.rotation);
            }

            if (randNo1 == 9)
            {
                Instantiate(girl1, new Vector3(0, 0.5f, zScenePos), girl1.rotation);
            }
            if (randNo1 == 10)
            {
                Instantiate(girl1, new Vector3(1, 0.5f, zScenePos), girl1.rotation);
            }
            if (randNo1 == 11)
            {
                Instantiate(girl1, new Vector3(2, 0.5f, zScenePos), girl1.rotation);
            }

            if (randNo1 == 12)
            {
                Instantiate(girl2, new Vector3(0, 0.5f, zScenePos), girl2.rotation);
            }
            if (randNo1 == 13)
            {
                Instantiate(girl2, new Vector3(1, 0.5f, zScenePos), girl2.rotation);
            }
            if (randNo1 == 14)
            {
                Instantiate(girl2, new Vector3(2, 0.5f, zScenePos), girl2.rotation);
            }

            if (randNo1 == 15)
            {
                Instantiate(garbage, new Vector3(2, 0.5f, zScenePos), garbage.rotation);
            }
            if (randNo1 == 16)
            {
                Instantiate(garbage, new Vector3(0, 0.5f, zScenePos), garbage.rotation);
            }

            if (randNo1 == 17)
            {
                Instantiate(car, new Vector3(-2, 0.5f, zScenePos), car.rotation);
            }
            if (randNo1 == 18)
            {
                Instantiate(car, new Vector3(-5, 0.5f, zScenePos), car.rotation);
            }



        }

        timeNow = timeNow + Time.deltaTime;

        if(levelStat=='f')
        {
            waitTime = waitTime + Time.deltaTime;

        }
        if(waitTime>1)
        {
            SceneManager.LoadScene("mainlevel");
        }
    }
}
