using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpaceManager : MonoBehaviour {

    List<GameObject> hexSpaces;
    private int hexNumber = 0;
    

	// Use this for initialization
	void Start () {

        hexSpaces = new List<GameObject>();
        foreach (Transform child in transform)
        {
            hexSpaces.Add(child.gameObject);
        }

        foreach (GameObject hex in hexSpaces)
        {
            var thisHex = hex.GetComponent<Hex>();
            thisHex.hexValue = hexNumber;
            hexNumber++;
        }
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
