using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjects : MonoBehaviour
{
    public GameObject[] rotateObjects;
    void FixedUpdate()
    {
        foreach (GameObject obj in rotateObjects)
        {
            obj.transform.Rotate(new Vector3(0, 1, 0));
        }
    }
}
