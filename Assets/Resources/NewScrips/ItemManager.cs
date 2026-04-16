using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject item;

    public float createTime = 8f;
    float currentTime = 0f;

    public float minX = -2.3f;
    public float maxX = 2.3f;
    public float createY = 6f;

    void Update()
    {
        currentTime = currentTime + Time.deltaTime;

        if (currentTime > createTime)
        {
            GameObject itemCopy = Instantiate(item);

            float randomX = Random.Range(minX, maxX);
            itemCopy.transform.position = new Vector3(randomX, createY, 0);

            currentTime = 0f;
        }
    }
}