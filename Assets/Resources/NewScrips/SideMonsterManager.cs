using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMonsterManager : MonoBehaviour
{
    public GameObject sideMonster;

    public float createTime = 4f;
    float currentTime = 0f;

    public float leftX = -4f;
    public float rightX = 4f;
    public float minY = -2f;
    public float maxY = 4f;

    void Update()
    {
        currentTime = currentTime + Time.deltaTime;

        if (currentTime > createTime)
        {
            GameObject monsterCopy = Instantiate(sideMonster);

            float randomY = Random.Range(minY, maxY);
            int rnd = Random.Range(0, 2);

            if (rnd == 0)
            {
                monsterCopy.transform.position = new Vector3(leftX, randomY, 0);

                SideMonster sideMonsterScript = monsterCopy.GetComponent<SideMonster>();
                sideMonsterScript.direct = Vector3.right;
            }
            else
            {
                monsterCopy.transform.position = new Vector3(rightX, randomY, 0);

                SideMonster sideMonsterScript = monsterCopy.GetComponent<SideMonster>();
                sideMonsterScript.direct = Vector3.left;
            }

            currentTime = 0f;
        }
    }
}