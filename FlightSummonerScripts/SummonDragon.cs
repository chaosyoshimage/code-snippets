using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK.Examples
{

    public class SummonDragon : VRTK_InteractableObject
    {

        AudioSource audio;
        
        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            Debug.Log("summon dragon");
            if (!GameController.isDragonSummoned)
            {
                SummonDragonSpell();
                audio.Play();
            }

           
        }

        // Use this for initialization
        void Start()
        {
            audio = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {

        }


        private void SummonDragonSpell()
        {
            GameController.isDragonSummoned = true;
        }
    }
}
