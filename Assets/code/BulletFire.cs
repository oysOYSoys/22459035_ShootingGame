using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletObject;
    public GameObject bulletFireObjact;

    void Update()
    {
        bool isFire = Input.GetButtonDown("Jump");
        if(isFire )
        {
            GameObject bullet = Instantiate(bulletObject);
            bullet.transform.position = bulletFireObjact.transform.position;
        }
    }
}
