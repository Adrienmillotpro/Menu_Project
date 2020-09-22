using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public CameraController CameraController;
    
    


    void Update()
    {
        

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {

            if (hit.transform.name == "CubePC")
            {
                
                if (Input.GetMouseButtonDown(0))
                {
                    CameraController.CameraNumberOne();
                }
            }

           

            if (hit.transform.name == "SinglePlayer")
            {
                //  Debug.Log(hit.transform.name);
                
                if (Input.GetMouseButtonDown(0))
                {
                    CameraController.CameraNumberTwo();
                }
                

            }

            if (hit.transform.name == "BlackBoard")
            {
                //  Debug.Log(hit.transform.name);
               
                if (Input.GetMouseButtonDown(0))
                {
                    CameraController.CameraNumberThree();
                }
                

            }

            if (hit.transform.name == "GetOut")
            {
                //  Debug.Log(hit.transform.name);
                
                if (Input.GetMouseButtonDown(0))
                {
                    CameraController.CameraNumberFour();
                }
                

            }
        }





    }
}
