using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    Gun data;
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int yPos;
    public int enemyCount;

    private void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 5)
        {
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 50);
            yPos = Random.Range(1, 10);
            Instantiate(theEnemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount++;
        }

        while (enemyCount < 100)
        {
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 50);
            yPos = Random.Range(1, 10);
            Instantiate(theEnemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            yield return new WaitForSeconds(3f);
            enemyCount++;
        }
    }
}
