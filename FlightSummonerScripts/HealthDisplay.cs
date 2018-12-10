using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour {

    private Transform childText;
    private TextMesh healthText;

	// Use this for initialization
	void Start () {

        childText = transform.GetChild(0);
        healthText = childText.GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {

        healthText.text = GameController.playerHealth.ToString();
	}
}
