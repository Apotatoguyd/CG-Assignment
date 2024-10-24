using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LUT : MonoBehaviour
{
    public Material render;

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, render);
    }
}
