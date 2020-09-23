using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Hovering_Clicking : MonoBehaviour
{
    public Outline Outline_Script;
    [SerializeField, Range(0f, 20f)]
    private float OutlineWidth = 2f;
    // Start is called before the first frame update
    void Awake()
    {
        Outline_Script.OutlineWidth = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        
    }
    private void OnMouseEnter()
    {
        Outline_Script.OutlineWidth = OutlineWidth;
    }
    private void OnMouseExit()
    {
        Outline_Script.OutlineWidth = 0.0f;
    }
}
