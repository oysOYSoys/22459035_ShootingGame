using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSub : MonoBehaviour
{
    public GameObject leftSub1;
    public GameObject rightSub1;
    public GameObject leftSub2;
    public GameObject rightSub2;

    public int itemCount = 0;

    public void AddSub()
    {
        itemCount++;

        if (itemCount == 1)
        {
            leftSub1.SetActive(true);
        }
        else if (itemCount == 2)
        {
            rightSub1.SetActive(true);
        }
        else if (itemCount == 3)
        {
            leftSub2.SetActive(true);
        }
        else if (itemCount == 4)
        {
            rightSub2.SetActive(true);
        }
    }
}