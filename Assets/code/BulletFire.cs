using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Fire : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletObject;
    public GameObject bulletFireObjact;

    void Start()
    {
        bool isFire = Input.GetButtonDown("Fire1");
        if(isFire )
        {
            GameObject bullet = Instantiate(bulletObject);
            bullet.transform.position = bulletFireObjact.transform.position;
        }
    }
}
