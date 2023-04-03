using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float _enemyTime;
    public EnemySpawner spawner;

    public void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner").gameObject.GetComponent<EnemySpawner>();
        foreach (Transform t in MovedTranform())
        {
            t.DOMove(Vector3.zero, _enemyTime).OnComplete(() =>
            {
                Completed();
            });
        }
    }

    public abstract Transform[] MovedTranform();

    public abstract void Completed();
}
