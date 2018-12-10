using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

public class SpawnBat : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject batPrefab;
       
    private bool CanShoot;
    Animation anim;
    AudioSource audio;


    // Use this for initialization
    void Start()
    {
       
       
        CanShoot = true;
        audio = transform.GetChild(0).GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (CanShoot == true && !GameController.isGameOever)
        {
           
            CanShoot = false;
            Fire();
            StartCoroutine(Reload(6.0f));
        }
    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bat = (GameObject)Instantiate(
            batPrefab,
            spawnPoint.position,
            spawnPoint.rotation);
        audio.Play();

        // Add velocity to the bat
       // bat.GetComponent<Rigidbody>().velocity = transform.forward * 3;

    }

    private IEnumerator Reload(float time)
    {
        yield return new WaitForSeconds(time);
        CanShoot = true;
    }


}
