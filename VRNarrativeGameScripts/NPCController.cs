using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour

{
    public Transform playerCharacter;
    
    public Vector3 lookatposition; 

	// Use this for initialization
	void Start () {
             
    }
	
	// Update is called once per frame
	void Update () {

        lookatposition = new Vector3( playerCharacter.position.x , transform.position.y, playerCharacter.position.z);
        transform.LookAt(lookatposition);

        
    }
}
