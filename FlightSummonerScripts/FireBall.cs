using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

public class FireBall : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject fireballPrefab;
    public Transform parentObject;
    private FlyingObject flyingObjectScript;
    private bool CanShoot;
    Animation anim;
    


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animation>();
        flyingObjectScript = parentObject.GetComponent<FlyingObject>();
        CanShoot = true;

    }
	
	// Update is called once per frame
	void Update () {
		if (flyingObjectScript.touchPadPressed == true && CanShoot == true )
        {
            anim.Play("mouthShoot");
            CanShoot = false;
            Fire();
            StartCoroutine(Reload(0.2f));
        }
	}


    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var fireBall = (GameObject)Instantiate(
            fireballPrefab,
            spawnPoint.position,
            spawnPoint.rotation);

        // Add velocity to the bullet
        fireBall.GetComponent<Rigidbody>().velocity = parentObject.transform.forward * 6;

        // Destroy the bullet after 2 seconds
        Destroy(fireBall, 5.0f);
    }

    private IEnumerator Reload(float time)
    {
        yield return new WaitForSeconds(time);
        CanShoot = true;
    }


}
