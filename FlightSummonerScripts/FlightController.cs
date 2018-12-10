namespace VRTK.Examples
{

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class FlightController : MonoBehaviour
    {

        public GameObject flyingObject;
        private FlyingObject flyingObjectScript;
        public GameObject gameController;
        private GameController gameControllerScript;

        // Use this for initialization
        void Start()
        {
            flyingObjectScript = flyingObject.GetComponent<FlyingObject>();
            gameControllerScript = gameController.GetComponent<GameController>();
            GetComponent<VRTK_ControllerEvents>().TriggerAxisChanged += new ControllerInteractionEventHandler(DoTriggerAxisChanged);
            GetComponent<VRTK_ControllerEvents>().TouchpadPressed += new ControllerInteractionEventHandler(DoButtonPressed);
            GetComponent<VRTK_ControllerEvents>().TouchpadReleased += new ControllerInteractionEventHandler(DoButtonReleased);
            GetComponent<VRTK_ControllerEvents>().GripPressed += new ControllerInteractionEventHandler(DoGripPressed);
        }

        // Update is called once per frame
        void Update()
        {
            

        }       

        private void DoTriggerAxisChanged(object sender, ControllerInteractionEventArgs e)
        {
            gameControllerScript.SetTriggerAxis(e.buttonPressure);
        }

        public void DoButtonPressed(object sender, ControllerInteractionEventArgs e)
        {
            flyingObjectScript.touchPadPressed = true;
        }
        public void DoButtonReleased(object sender, ControllerInteractionEventArgs e)
        {
            flyingObjectScript.touchPadPressed = false;
        }

        public void DoGripPressed(object sender, ControllerInteractionEventArgs e)
        {
            flyingObjectScript.ResetPosition();
        }



        public void SummonDragonCommand()
        {
            flyingObject.SetActive(true);
        }

    }
}