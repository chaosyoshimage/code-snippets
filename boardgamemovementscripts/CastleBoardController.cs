using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastleBoardController : MonoBehaviour {

    public static int boardTurn = 0;
    public static bool diceRolled = false;
    public static bool castleLesson1Played = false;
    public static bool castleLesson2Played = false;
    public static bool castleLesson3Played = false;
    public GameObject reviewButton1;
    public GameObject reviewButton2;
    public GameObject reviewButton3;
    public static bool firstTurnTaken = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (boardTurn == 0 && diceRolled == false && castleLesson1Played == false && MovementController.battleReady == false && SceneManager.GetActiveScene().name == "Castle Level")
        {

            castleLesson1Played = true;

            SceneManager.LoadScene("Castle Lesson 1", LoadSceneMode.Single);

        }

        if (boardTurn == 2 && diceRolled == false && castleLesson2Played == false && MovementController.battleReady == false && SceneManager.GetActiveScene().name == "Castle Level")

        {

            castleLesson2Played = true;

            SceneManager.LoadScene("Castle Lesson 2", LoadSceneMode.Single);


        }

        if (boardTurn == 4 && diceRolled == false && castleLesson3Played == false && MovementController.battleReady == false && SceneManager.GetActiveScene().name == "Castle Level")

        {

            castleLesson3Played = true;

            SceneManager.LoadScene("Castle Lesson 3", LoadSceneMode.Single);


        }

        if (castleLesson1Played == true && SceneManager.GetActiveScene().name == "Castle Level")

        {

            reviewButton1.SetActive(true);

        }

        if (castleLesson2Played == true && SceneManager.GetActiveScene().name == "Castle Level")

        {

            reviewButton2.SetActive(true);

        }

        if (castleLesson3Played == true && SceneManager.GetActiveScene().name == "Castle Level")

        {

            reviewButton3.SetActive(true);

        }



    }
}

