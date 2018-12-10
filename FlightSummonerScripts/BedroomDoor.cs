using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace VRTK.Examples
{
    
    public class BedroomDoor : VRTK_InteractableObject
    {

        private bool canOpen;

        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            Debug.Log("using item");
            if(canOpen == true)
            SceneManager.LoadScene("TransitionLevel", LoadSceneMode.Single);
             
        }
        // Use this for initialization
        void Start()
        {
            canOpen = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (GameController.levelConditions == true)
            {
                touchHighlightColor = Color.green;
                touchHighlightColor.g = 255;
                touchHighlightColor.r = 0;
                canOpen = true;
            }
        }
        



    }
}
