using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static bool levelConditions = false;
    public static bool messageRecieved = false;
    public static bool triggerPressed = false;
    public static bool isDragonSummoned = true;
    public static float playerHealth = 50;
    public static int bossHealth = 500;
    public static bool hasGameStarted = false;
    public static bool isPlayerDead = false;
    public static bool isGameOever = false;
    public static float isTriggerPressed = 0;
    


    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		


	}

    public void SetTriggerAxis(float data)
    {
        isTriggerPressed = data;
    }
}
