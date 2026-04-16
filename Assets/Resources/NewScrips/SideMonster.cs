using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMonster : MonoBehaviour
{
    public float spd = 3f;
    public Vector3 direct = Vector3.right;

    public GameObject prefabsExplosion;

    void Update()
    {
        transform.Translate(direct * spd * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            GameObject gameManager = GameObject.Find("GameManager");
            ScoreManager scoreManager = gameManager.GetComponent<ScoreManager>();

            scoreManager.nowScore += 2;
            scoreManager.nowScoreUI.text = "Now Score : " + scoreManager.nowScore;

            if (scoreManager.nowScore > scoreManager.bestScore)
            {
                scoreManager.bestScore = scoreManager.nowScore;
                scoreManager.bestScoreUI.text = "Best Score : " + scoreManager.bestScore;
            }

            GameObject explosionObj = Instantiate(prefabsExplosion);
            explosionObj.transform.position = transform.position;

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}