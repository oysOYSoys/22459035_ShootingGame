using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            GameObject uiManager = GameObject.Find("UIManager");
            GameUI manager = uiManager.GetComponent<GameUI>();
            manager.ShowGameOver();

            gameObject.SetActive(false);
        }
    }
}