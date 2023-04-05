using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public List<string> directions;
    public Enemy[] Enemies;
    public Transform[] spawnPosition;
    public WarningControl[] warnings;

    public float minTime, maxTime;

    private float timer = 0;
    private float SpawnTime;
    public int rndmPos;
    Wind win;

    private void Start()
    {
        SpawnTime = Random.Range(minTime, maxTime);
        timer = SpawnTime;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > SpawnTime)
        {
            timer = 0;
            SpawnTime = Random.Range(minTime, maxTime);
            EnemyInstantiate();
        }
    }
    
    private void EnemyInstantiate()
    {
        int rndmEnemy = Random.Range(0, Enemies.Length);

        Enemy enemy = Enemies[rndmEnemy];

        if(enemy is Ghost)
        {
            int rndmPos = Random.Range(0, spawnPosition.Length);

            Transform t = spawnPosition[rndmPos];

            UyariDirection(rndmPos);

            Instantiate(enemy, t.position, Quaternion.identity);
        }
        else if(enemy is Thorn)
        {
            Instantiate(enemy);

            UyariDirection("Top");
            UyariDirection("Bottom");

        }
        else if(enemy is Wind)
        {
            rndmPos = Random.Range(0, 2);
            Transform t = spawnPosition[rndmPos];
            UyariDirection(rndmPos);
            GameObject wind = Instantiate(enemy, t.position, Quaternion.identity).gameObject;
            if (t.position.x>0)
            {
                Vector3 temp = wind.transform.localScale;
                temp.x = 1;
                wind.transform.localScale = temp;
            }
            if (t.position.x<0)
            {
                Vector3 temp = wind.transform.localScale;
                temp.x = -1;
                wind.transform.localScale = temp; //bu þekilde :D vaktin varmý eevt birde bu karekter collisiondan etkilenmiyor yani dicen var ya normalde var ama içine girebilio
            }
        }
    }

    public void UyariDirection(string direction)
    {
        if (directions.Contains(direction))
        {
            int i = directions.IndexOf(direction);

            warnings[i].gameObject.SetActive(true);
            warnings[i].StartWarning();
        }
        else
        {
            Debug.Log("Hatali direction");
        }
    }
    public void UyariDirection(int index)
    {
        warnings[index].gameObject.SetActive(true); 
        warnings[index].StartWarning();
    }
}
