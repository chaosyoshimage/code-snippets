using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : MonoBehaviour {

    public float timer;
    public int healthPoints;
    private Rigidbody rb;
    


	// Use this for initialization
	void Start () {

        healthPoints = GameController.bossHealth;
        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, timer * 20, 0);
        transform.position = new Vector3(3.81f, Mathf.Sin(timer) * 2, 9.51f);
        healthPoints = GameController.bossHealth;

        if (healthPoints <= 0)
        {
            rb.useGravity = true;
           // rb.isKinematic = false;
        }
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fireball")
        {
            healthPoints -= 10;
            Destroy(collision.gameObject);

        }

        GameController.bossHealth = healthPoints;
    }
}
