using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

public class ReaperSlash : MonoBehaviour {

        Animation anim;
    private FlyingObject flyingObjectScript;
    public GameObject bossEnemy;
    private float dist;
    private GameObject[] bats;
    ParticleSystem parSys;
    private GameObject graveYard;

        // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animation>();
        flyingObjectScript = transform.parent.GetComponent<FlyingObject>();
        parSys = GetComponent<ParticleSystem>();
        graveYard = GameObject.FindGameObjectWithTag("Graveyard");
    }

        // Update is called once per frame
        void Update()
    {

            if (flyingObjectScript.touchPadPressed == true && !anim.isPlaying)
            {
                Slash();
            }

    }

        void Slash()
        {
        parSys.Play();
        anim.Play("slash");
        dist = Vector3.Distance(bossEnemy.transform.position, transform.position);
        if (dist < 10)
            GameController.bossHealth -= 20;


        bats = GameObject.FindGameObjectsWithTag("enemy");

        foreach(var bat in bats)
        {
            dist = Vector3.Distance(bat.transform.position, transform.position);
            if (dist < 3)
            {
                bat.transform.parent = graveYard.transform;
                bat.SetActive(false);
            }
        }
            
        }
}
