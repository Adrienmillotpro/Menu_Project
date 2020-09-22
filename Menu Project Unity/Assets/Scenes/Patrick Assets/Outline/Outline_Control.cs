using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outline_Control : MonoBehaviour
{
    private MeshRenderer Typical_Renderer;

    public float maxOutlineWidth;

    public Color OutlineColor;

    private void Start()
    {
        Typical_Renderer = GetComponent<MeshRenderer>();
    }

    public void ShowOutline()
    {
        Typical_Renderer.material.SetFloat("Outline", maxOutlineWidth);
        Typical_Renderer.material.SetColor("OutlineColor", OutlineColor);
    }
    public void HideOutline()
    {
        Typical_Renderer.material.SetFloat("Outline", 0f);
    }
}
