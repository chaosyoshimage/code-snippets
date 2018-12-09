using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class MouseManager : MonoBehaviour
{

    Unit selectedUnit;
    

    // Use this for initialization
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

        //Debug.Log( "Mouse Position: " + Input.mousePosition);

       
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;

        if (Input.GetMouseButtonDown(0)) /// check if we're cliking the mouse button, and only cast a ray if we are
        {


            if (Physics.Raycast(ray, out hitInfo))
            {
                GameObject ourHitObject = hitInfo.collider.transform.gameObject;
                Debug.Log(ourHitObject);
                // What kind of object are we over?
                if (ourHitObject.GetComponent<Hex>() != null)
                {
                    MouseOver_Hex(ourHitObject);
                }
                else if (ourHitObject.GetComponent<Unit>() != null)
                {
                    //Over a unit
                    MouseOver_Unit(ourHitObject);
                }

              

            }
        }
       
    }

    void MouseOver_Hex(GameObject ourHitObject)
    {
           MeshRenderer mr = ourHitObject.GetComponent<MeshRenderer>();

            if (mr.material.color == Color.red)
            {
                mr.material.color = Color.white;
            }
            else
            {


                mr.material.color = Color.red;
            }

            //If unit is selected, move it to this tile
            if (selectedUnit != null)
        {
            selectedUnit.destination = ourHitObject.transform.position;
        }
        
    }

    void MouseOver_Unit(GameObject ourHitObject)
    {
        Debug.Log("Raycast hit:" + ourHitObject.name);
        if (Input.GetMouseButtonDown(0))
        {
            selectedUnit = ourHitObject.GetComponent<Unit>();
        }
    }
}



