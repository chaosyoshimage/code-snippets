using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    Rigidbody rb;
    public GameObject player;
    public float speed;
    private Vector3 lookatposition;
    Animation anim;
    public GameObject graveyard;
    private Collider batCollider;
    

    // Use this for initialization
    void Start () {
        speed = 1;
        rb = GetComponent<Rigidbody>();
        anim = transform.GetChild(0).GetComponent<Animation>();
        anim.Play("Take 001");
        player = GameObject.FindGameObjectWithTag("MainCamera");
        graveyard = GameObject.FindGameObjectWithTag("Graveyard");
        batCollider = GetComponent<Collider>();



    }

    // Update is called once per frame
    void Update ()
    {
        
        player = GameObject.FindGameObjectWithTag("MainCamera");


        float step = speed * Time.deltaTime;
        GetNewPosition(step);
        lookatposition = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        transform.LookAt(lookatposition);
        anim["Take 001"].speed = 3.0f;
        if ( GameController.isGameOever)
        {
            transform.parent = graveyard.transform;
            this.gameObject.SetActive(false);
        }
    }

    private void GetNewPosition(float step)
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "player" || collision.gameObject.tag == "MainCamera" && !GameController.isGameOever)
        {
            transform.parent = graveyard.transform;
            GameController.playerHealth -= 10;
            this.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "fireball")
        {
            transform.parent = graveyard.transform;
            this.gameObject.SetActive(false);
            

        }

        if (collision.gameObject.tag != "player" && collision.gameObject.tag != "fireball")
        {
            Physics.IgnoreCollision(collision.collider, batCollider);
        }




    }
}
