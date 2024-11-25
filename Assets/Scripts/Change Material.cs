using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    
    // CODE FROM: https://www.youtube.com/watch?v=5rZ_QoVHPkQ 
    
    public Material defaultMaterial;
    public Material selectedMaterial;
    public GameObject[] surface;
    
    public MeshRenderer[] _object;

    void Start()
    {
        for (int i = 0; i < _object.Length; i++)
        {
            _object[i] = surface[i].GetComponent<MeshRenderer>();
            selectedMaterial = _object[i].material;
            defaultMaterial.mainTextureScale = selectedMaterial.mainTextureScale;
        }

    }

    public void SwapMaterial()
    {
        for (int i = 0; i < surface.Length; i++)
        {
            _object[i].material = _object[i].material.name.StartsWith(defaultMaterial.name) ? selectedMaterial : defaultMaterial;
        }
        
    }
}
