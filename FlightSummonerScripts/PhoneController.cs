using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK.Examples
{

    public class PhoneController : VRTK_InteractableObject
    {
        //sound setup 
        AudioSource audio;
        public AudioClip phoneRingClip;
        public AudioClip phoneTalkClip;

        public override void Grabbed(VRTK_InteractGrab grabbedObject)
        {
            Debug.Log("pickedup phone");
            audio.Stop();
            audio.clip = phoneTalkClip;
            audio.loop = false;
            if (GameController.messageRecieved == false)
            {
                GameController.messageRecieved = true;
                StartCoroutine(StartTalking(2.0f));
            }

        }
        // Use this for initialization
        void Start()
        {
            audio = GetComponent<AudioSource>();
            StartCoroutine(StartRinging(7.0f));

        }


        // Update is called once per frame
        void Update()
        {

        }

        private IEnumerator StartRinging(float waitTime)
        {

            yield return new WaitForSeconds(waitTime);
           
            audio.Play();
        }

        private IEnumerator StartTalking(float waitTime)
        {

            yield return new WaitForSeconds(waitTime);
            GameController.levelConditions = true;
            audio.Play();
            GameController.messageRecieved = true;
        }
    }
}
