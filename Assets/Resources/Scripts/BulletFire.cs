using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletPoint;

    public GameObject leftSub1;
    public GameObject rightSub1;
    public GameObject leftSub2;
    public GameObject rightSub2;

    CharacterSub characterSub;

    void Start()
    {
        characterSub = GetComponent<CharacterSub>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject bulletObject = Instantiate(bullet);
            bulletObject.transform.position = bulletPoint.transform.position;

            if (characterSub.itemCount >= 1)
            {
                GameObject leftBullet1 = Instantiate(bullet);
                leftBullet1.transform.position = leftSub1.transform.position;
            }

            if (characterSub.itemCount >= 2)
            {
                GameObject rightBullet1 = Instantiate(bullet);
                rightBullet1.transform.position = rightSub1.transform.position;
            }

            if (characterSub.itemCount >= 3)
            {
                GameObject leftBullet2 = Instantiate(bullet);
                leftBullet2.transform.position = leftSub2.transform.position;
            }

            if (characterSub.itemCount >= 4)
            {
                GameObject rightBullet2 = Instantiate(bullet);
                rightBullet2.transform.position = rightSub2.transform.position;
            }
        }
    }
}