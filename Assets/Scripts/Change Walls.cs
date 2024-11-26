using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWalls : MonoBehaviour
{
    public Material defaultMaterial;
    public Material selectedMaterial;
    public GameObject[] wall;

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
        
        for (int j = 0; j < wall.Length; j++)
        {
            wall[j].gameObject.GetComponent<MeshRenderer>().material = _object[j].material.name.StartsWith(defaultMaterial.name) ? selectedMaterial : defaultMaterial;
        }
    }
}
