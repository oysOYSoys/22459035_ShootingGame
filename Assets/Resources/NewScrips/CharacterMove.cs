using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float spd = 5f;

    public float minX = -2.3f;
    public float maxX = 2.3f;
    public float minY = -4.3f;
    public float maxY = 4.3f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direct = new Vector3(h, v, 0);

        transform.position = transform.position + direct * spd * Time.deltaTime;

        Vector3 pos = transform.position;

        if (pos.x < minX) pos.x = minX;
        if (pos.x > maxX) pos.x = maxX;
        if (pos.y < minY) pos.y = minY;
        if (pos.y > maxY) pos.y = maxY;

        transform.position = pos;
    }
}