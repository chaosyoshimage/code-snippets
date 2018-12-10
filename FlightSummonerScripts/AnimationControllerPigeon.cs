using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerPigeon : MonoBehaviour {

    Animation anim;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animation>();
        anim["Take 001"].speed = 8f;
        
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
