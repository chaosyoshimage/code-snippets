using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour {

    public GameObject hand;
    private Collider handCollider;

	// Use this for initialization
	void Start () {

        handCollider = hand.GetComponent<Collider>();

	}

    private void OnCollisionEnter(Collision collision)
    {
        
            if (collision.gameObject.tag != "cloth")
            {
                Physics.IgnoreCollision(collision.collider, handCollider);
            }
        }
    // Update is called once per frame
    void Update () {
		
	}
}
