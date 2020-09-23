using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Hovering_Clicking : MonoBehaviour
{
    public Outline Outline_Script;
    // Start is called before the first frame update
    void Awake()
    {
        Outline_Script.OutlineWidth = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        Outline_Script.OutlineWidth = 7.0f;
    }
    private void OnMouseExit()
    {
        Outline_Script.OutlineWidth = 0.0f;
    }
}
