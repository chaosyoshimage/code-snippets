using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonRotate : MonoBehaviour {

    private float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, timer * 20, 0);

    }
}
