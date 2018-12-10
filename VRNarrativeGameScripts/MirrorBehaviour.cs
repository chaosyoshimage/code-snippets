using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBehaviour : MonoBehaviour {

    public Transform MirrorCam;
    public Transform Playercam; 
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CalculateRotation();
	}

    private void CalculateRotation()
    {
        Vector3 dir = (Playercam.position - transform.position).normalized;
        Quaternion rot = Quaternion.LookRotation(dir);

        rot.eulerAngles = transform.eulerAngles - rot.eulerAngles;

        MirrorCam.localRotation = rot;
    }
}
