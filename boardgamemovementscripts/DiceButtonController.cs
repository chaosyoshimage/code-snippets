using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DiceButtonController : MonoBehaviour {

    public Sprite Dice1;
    public Sprite Dice2;
    public Sprite Dice3;
    public Sprite Dice4;
    public Sprite Dice5;
    public Sprite Dice6;
    public Button Dice;
    public int DiceValue;

    public void DiceRoller()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        DiceValue = Random.Range(1, 7);
        
        if (DiceValue == 1 && VillageBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Village Mockup")
        {
            Dice.image.sprite = Dice1;
            MovementController.movement += 1;
           
            
            VillageBoardController.boardTurn += 1;
            VillageBoardController.diceRolled = true;

        }
        if (DiceValue == 2 && VillageBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Village Mockup")
        {
            Dice.image.sprite = Dice2;
            MovementController.movement += 2;
            
            
            VillageBoardController.boardTurn += 1;
            VillageBoardController.diceRolled = true;

        }
        if (DiceValue == 3 && VillageBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Village Mockup")
        {
            Dice.image.sprite = Dice3;
            MovementController.movement += 3;
            
            
            VillageBoardController.boardTurn += 1;
            VillageBoardController.diceRolled = true;

        }
        if (DiceValue == 4 && VillageBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Village Mockup")
        {
            Dice.image.sprite = Dice4;
            MovementController.movement += 4;
            
            
            VillageBoardController.boardTurn += 1;
            VillageBoardController.diceRolled = true;

        }
        if (DiceValue == 5 && VillageBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Village Mockup")
        {
            Dice.image.sprite = Dice5;
            MovementController.movement += 5;
            
            
            VillageBoardController.boardTurn += 1;
            VillageBoardController.diceRolled = true;
        }
        if (DiceValue == 6 && VillageBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Village Mockup")
        {
            Dice.image.sprite = Dice6;
            MovementController.movement += 6;
            
            
            VillageBoardController.boardTurn += 1;
            VillageBoardController.diceRolled = true;

        }
        if (DiceValue == 1 && ForestBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Forest Level")
        {
            Dice.image.sprite = Dice1;
            MovementController.movement += 1;
            
            
            ForestBoardController.boardTurn += 1;
            ForestBoardController.diceRolled = true;
            ForestBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 2 && ForestBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Forest Level")
        {
            Dice.image.sprite = Dice2;
            MovementController.movement += 2;
            
           
            
            ForestBoardController.boardTurn += 1;
            ForestBoardController.diceRolled = true;
            ForestBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 3 && ForestBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Forest Level")
        {
            Dice.image.sprite = Dice3;
            MovementController.movement += 3;
            
           
            
            ForestBoardController.boardTurn += 1;
            ForestBoardController.diceRolled = true;
            ForestBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 4 && ForestBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Forest Level")
        {
            Dice.image.sprite = Dice4;
            MovementController.movement += 4;
           
            
            
            ForestBoardController.boardTurn += 1;
            ForestBoardController.diceRolled = true;
            ForestBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 5 && ForestBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Forest Level")
        {
            Dice.image.sprite = Dice5;
            MovementController.movement += 5;
           
            
            
            ForestBoardController.boardTurn += 1;
            ForestBoardController.diceRolled = true;
            ForestBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 6 && ForestBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Forest Level")
        {
            Dice.image.sprite = Dice6;
            MovementController.movement += 6;
           
            
            
            ForestBoardController.boardTurn += 1;
            ForestBoardController.diceRolled = true;
            ForestBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 1 && CoastalBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Coastal Level")
        {
            Dice.image.sprite = Dice1;
            MovementController.movement += 1;


            CoastalBoardController.boardTurn += 1;
            CoastalBoardController.diceRolled = true;
            CoastalBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 2 && CoastalBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Coastal Level")
        {
            Dice.image.sprite = Dice2;
            MovementController.movement += 2;



            CoastalBoardController.boardTurn += 1;
            CoastalBoardController.diceRolled = true;
            CoastalBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 3 && CoastalBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Coastal Level")
        {
            Dice.image.sprite = Dice3;
            MovementController.movement += 3;



            CoastalBoardController.boardTurn += 1;
            CoastalBoardController.diceRolled = true;
            CoastalBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 4 && CoastalBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Coastal Level")
        {
            Dice.image.sprite = Dice4;
            MovementController.movement += 4;



            CoastalBoardController.boardTurn += 1;
            CoastalBoardController.diceRolled = true;
            CoastalBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 5 && CoastalBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Coastal Level")
        {
            Dice.image.sprite = Dice5;
            MovementController.movement += 5;



            CoastalBoardController.boardTurn += 1;
            CoastalBoardController.diceRolled = true;
            CoastalBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 6 && CoastalBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Coastal Level")
        {
            Dice.image.sprite = Dice6;
            MovementController.movement += 6;



            CoastalBoardController.boardTurn += 1;
            CoastalBoardController.diceRolled = true;
            CoastalBoardController.firstTurnTaken = true;
        }

        if (DiceValue == 1 && NewgrangeBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Newgrange Level")
        {
            Dice.image.sprite = Dice1;
            MovementController.movement += 1;


            NewgrangeBoardController.boardTurn += 1;
            NewgrangeBoardController.diceRolled = true;
            NewgrangeBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 2 && NewgrangeBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Newgrange Level")
        {
            Dice.image.sprite = Dice2;
            MovementController.movement += 2;



            NewgrangeBoardController.boardTurn += 1;
            NewgrangeBoardController.diceRolled = true;
            NewgrangeBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 3 && NewgrangeBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Newgrange Level")
        {
            Dice.image.sprite = Dice3;
            MovementController.movement += 3;



            NewgrangeBoardController.boardTurn += 1;
            NewgrangeBoardController.diceRolled = true;
            NewgrangeBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 4 && NewgrangeBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Newgrange Level")
        {
            Dice.image.sprite = Dice4;
            MovementController.movement += 4;



            NewgrangeBoardController.boardTurn += 1;
            NewgrangeBoardController.diceRolled = true;
            NewgrangeBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 5 && NewgrangeBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Newgrange Level")
        {
            Dice.image.sprite = Dice5;
            MovementController.movement += 5;



            NewgrangeBoardController.boardTurn += 1;
            NewgrangeBoardController.diceRolled = true;
            NewgrangeBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 6 && NewgrangeBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Newgrange Level")
        {
            Dice.image.sprite = Dice6;
            MovementController.movement += 6;



            NewgrangeBoardController.boardTurn += 1;
            NewgrangeBoardController.diceRolled = true;
            NewgrangeBoardController.firstTurnTaken = true;
        }

        if (DiceValue == 1 && CastleBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Castle Level")
        {
            Dice.image.sprite = Dice1;
            MovementController.movement += 1;


            CastleBoardController.boardTurn += 1;
            CastleBoardController.diceRolled = true;
            CastleBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 2 && CastleBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Castle Level")
        {
            Dice.image.sprite = Dice2;
            MovementController.movement += 2;



            CastleBoardController.boardTurn += 1;
            CastleBoardController.diceRolled = true;
            CastleBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 3 && CastleBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Castle Level")
        {
            Dice.image.sprite = Dice3;
            MovementController.movement += 3;



            CastleBoardController.boardTurn += 1;
            CastleBoardController.diceRolled = true;
            CastleBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 4 && CastleBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Castle Level")
        {
            Dice.image.sprite = Dice4;
            MovementController.movement += 4;



            CastleBoardController.boardTurn += 1;
            CastleBoardController.diceRolled = true;
            CastleBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 5 && CastleBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Castle Level")
        {
            Dice.image.sprite = Dice5;
            MovementController.movement += 5;



            CastleBoardController.boardTurn += 1;
            CastleBoardController.diceRolled = true;
            CastleBoardController.firstTurnTaken = true;
        }
        if (DiceValue == 6 && CastleBoardController.diceRolled == false && SceneManager.GetActiveScene().name == "Castle Level")
        {
            Dice.image.sprite = Dice6;
            MovementController.movement += 6;



            CastleBoardController.boardTurn += 1;
            CastleBoardController.diceRolled = true;
            CastleBoardController.firstTurnTaken = true;
        }

        if (MovementController.movement >= 42)
        {
            MovementController.movement = 41;
        }

    }
}
