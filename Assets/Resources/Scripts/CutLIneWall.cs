using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutLIneWall : MonoBehaviour
{
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        Destroy(other.gameObject);
    }
}
