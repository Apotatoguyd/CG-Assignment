using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeWalls : MonoBehaviour
{
    public Material defaultMaterial;
    public Material selectedMaterial;
    public GameObject[] wall;
    public bool swapped;
    public MeshRenderer[] _object;
    // Start is called before the first frame update
    void Start()
    {
        wall = GameObject.FindGameObjectsWithTag("Wall");
        for(int j = 0; j < wall.Length; j++)
        {
            wall[j].gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
        }
    }

    public void ChangeWall()
    {
        if (swapped == false)
        {
            for (int j = 0; j < wall.Length; j++)
            {
                //wall[j].gameObject.GetComponent<MeshRenderer>().material = _object[j].material.name.StartsWith(defaultMaterial.name) ? selectedMaterial : defaultMaterial;
                wall[j].GetComponent<Renderer>().material = defaultMaterial;
                print(wall[j] + " changed material");
            }

            swapped = true;
        }

        else
        {
            for (int j = 0; j < wall.Length; j++)
            {
                //wall[j].gameObject.GetComponent<MeshRenderer>().material = _object[j].material.name.StartsWith(defaultMaterial.name) ? selectedMaterial : defaultMaterial;
                wall[j].GetComponent<Renderer>().material = selectedMaterial;
                print(wall[j] + " changed material");
            }

            swapped = false;
        }
    }
}
