using UnityEngine;
using System.Collections;

public class Hex : MonoBehaviour {

    //Our coordinates in the map array
    public int hexValue;
    public bool isBattleHex;
    public bool isBattleHex1;
    public bool isBattleHex2;
    public bool isBattleHex3;
    public bool isBattleHexBattle;

    // Use this for initialization
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (hexValue == MovementController.movement)
        {

            gameObject.GetComponent<Renderer>().material.color = Color.red;

        }

        if (hexValue != MovementController.movement)

        {

            gameObject.GetComponent<Renderer>().material.color = Color.white;

        }

    }
    
}
