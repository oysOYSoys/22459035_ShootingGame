using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutLIneWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
    }
}
