namespace VRTK.Examples
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class FlyingObject : MonoBehaviour
    {
        public float triggerAxis;
        public Transform controllerObject;
        public Quaternion objectRotation;
        public float speed;
        public Rigidbody rb;
        public bool touchPadPressed;
        public static Vector3 startPosition;
        Animation anim;
        AudioSource audio;


        // Use this for initialization
        void Start()
        {
            
            anim = transform.GetChild(0).GetComponent<Animation>();
            // anim.Play("mouthShoot");
            startPosition = transform.position;
            rb = GetComponent<Rigidbody>();
            audio = GetComponent<AudioSource>();
            // touchPadPressed = false;
            anim.Play("flapping");
            


        }

        // Update is called once per frame
        void Update()
        {

           rb.AddRelativeForce(Vector3.forward * triggerAxis * 5);
            transform.rotation = controllerObject.rotation;
            triggerAxis = GameController.isTriggerPressed;

             if (GameController.isDragonSummoned)
            {
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.SetActive(false);
            }
            else
            {
                transform.GetChild(1).gameObject.SetActive(true);
                transform.GetChild(0).gameObject.SetActive(false);
            }

            
                
                
            


           
        }

        //public void SetTriggerAxis(float data)
        //{
        //    triggerAxis = data;
        //}

        public void ResetPosition()
        {
            transform.position = startPosition;
            audio.Play();
        }


       

      
        

        
    }
}
