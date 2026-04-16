using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material materaialBG;

    public float scrollSpd = 0.2f;

    private void Update()
    {
        Vector2 direction = Vector2.up;
        materaialBG.mainTextureOffset += direction * scrollSpd * Time.deltaTime;
    }
}
