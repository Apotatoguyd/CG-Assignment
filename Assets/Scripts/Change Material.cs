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
    public GameObject[] chest;
    public bool swapped;
    public MeshRenderer[] _object;
    

    void Start()
    {
        for (int i = 0; i < surface.Length; i++)
        {
            _object[i] = surface[i].GetComponent<MeshRenderer>();
            selectedMaterial = _object[i].material;
            defaultMaterial.mainTextureScale = selectedMaterial.mainTextureScale;
        }
        for(int j = 0; j < chest.Length; j++)
        {
            chest[j].gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
        }
    }

    void Update()
    {
        chest = GameObject.FindGameObjectsWithTag("Chest");
    }
    public void SwapMaterial()
    {
        for (int i = 0; i < surface.Length; i++)
        {
            _object[i].material = _object[i].material.name.StartsWith(defaultMaterial.name) ? selectedMaterial : defaultMaterial;
        }

    }
    
    public void ChangeChest()
    {
        if (swapped == false)
        {
            for (int j = 0; j < chest.Length; j++)
            {
                //wall[j].gameObject.GetComponent<MeshRenderer>().material = _object[j].material.name.StartsWith(defaultMaterial.name) ? selectedMaterial : defaultMaterial;
                chest[j].GetComponent<Renderer>().material = defaultMaterial;
                print(chest[j] + " changed material");
            }

            swapped = true;
        }

        else
        {
            for (int j = 0; j < chest.Length; j++)
            {
                //wall[j].gameObject.GetComponent<MeshRenderer>().material = _object[j].material.name.StartsWith(defaultMaterial.name) ? selectedMaterial : defaultMaterial;
                chest[j].GetComponent<Renderer>().material = selectedMaterial;
                print(chest[j] + " changed material");
            }

            swapped = false;
        }
    }
}
