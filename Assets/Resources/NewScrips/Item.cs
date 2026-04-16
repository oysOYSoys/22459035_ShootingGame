using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float spd = 2f;

    void Update()
    {
        transform.position = transform.position + Vector3.down * spd * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CharacterSub characterSub = other.gameObject.GetComponent<CharacterSub>();
            characterSub.AddSub();

            Destroy(gameObject);
        }
    }
}