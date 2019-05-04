using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movesphere : MonoBehaviour
{
    public KeyCode moveL;
    public KeyCode moveR;

    public float xVel = 0;
    public int laneNum = 0;
    public char controlLocked = 'n';

    public Transform endObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(xVel, gamemaster.yVel, gamemaster.zVel);

        //gamemaster.timeNow = gamemaster.timeNow + Time.deltaTime; //we instead created a gamemaster object

        if ((Input.GetKeyDown(moveL)) && (laneNum>-1) &&(controlLocked == 'n')) //getkey will continuously detect it
        {
            xVel = -2;
            StartCoroutine(stopSlide());
            laneNum = laneNum - 1;
            controlLocked = 'y';
        }
        if ((Input.GetKeyDown(moveR)) && (laneNum <1) && (controlLocked == 'n')) 
        {
            xVel = 2;
            StartCoroutine(stopSlide());
            laneNum = laneNum + 1;
            controlLocked = 'y';
        }
    }

    void OnCollisionEnter(Collision obs)    //OnCollisionEnter is predefined like Start and Update
    {
        if(obs.gameObject.tag=="lethal")
        {
            //Destroy(obs.gameObject);
            Destroy(gameObject);
            gamemaster.zVel = 0;
            Instantiate(endObj, transform.position,endObj.rotation);
            gamemaster.levelStat = 'f';
        }
        if (obs.gameObject.name == "Capsule")
        {
            Destroy(obs.gameObject);
            //powerup
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="rampstarttrig")
        {
            gamemaster.yVel = 3*(gamemaster.zVel)/4;
        }
        if (other.gameObject.name == "rampendtrig")
        {
            gamemaster.yVel = 0;
        }
        if (other.gameObject.name == "exitgate")
        {
            gamemaster.levelStat = 'p';
            SceneManager.LoadScene("mainLevel");
        }
        if (other.gameObject.name == "coin"|| (other.gameObject.name == "coin(Clone)"))    //we can do this in collision too if we don't set it to trigger   //for the clone, only need when "name" is req, when comparing tag, it's fine
        {
            Destroy(other.gameObject);
            gamemaster.scoreNow = gamemaster.scoreNow + 1;
        }
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        xVel = 0;
        controlLocked = 'n';
    }
}
