using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VRTK.Examples
{

    public class HealthPickup : VRTK_InteractableObject
    {

        private MeshRenderer meshR;
        private SphereCollider sphereC;

        public override void StartTouching(VRTK_InteractTouch interactTouch)
        {
            ResetHeart(30);
            base.StartTouching(interactTouch);
            GameController.playerHealth += 10;
            meshR.enabled = false;
            sphereC.enabled = false;
            

        }

        // Use this for initialization
        void Start()
        {
            meshR = GetComponent<MeshRenderer>();
            sphereC = GetComponent<SphereCollider>();
        }

        // Update is called once per frame
        void Update()
        {

        }


        private IEnumerator ResetHeart(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            meshR.enabled = true;
            sphereC.enabled = true;
        }
    }
}
