using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public ParticleSystem p;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Player player))
        {
            player.Score();
            Debug.Log("touch");
            p.Play();
        }
        Destroy(gameObject);
        Debug.Log("touch");
    }

    private void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, 1, 0));
    }
}
