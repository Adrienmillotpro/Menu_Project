using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outline_Look_At : MonoBehaviour
{
    public Camera cam;
    public float dist;

    private Outline_Control prevController;
    private Outline_Control currentController;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleLookatRay();
    }

    private void HandleLookatRay() 
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, dist))
        {
            if (hit.collider.CompareTag("Interact"))
            {
                currentController = hit.collider.GetComponent<Outline_Control>();

                if (prevController != currentController) 
                {
                    HideOutline();
                    ShowOutline();
                }
                prevController = currentController;
            }
        }
        else 
        {
            HideOutline();
        }
    }

    private void ShowOutline()
    {
        if (currentController != null)
        {
            currentController.ShowOutline();
        }
    }

    private void HideOutline()
    {
        if (prevController != null)
        {
            prevController.HideOutline();
            prevController = null;
        }
    }
}
