using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Wind : Enemy
{
    public Rigidbody2D m_Rigidbody;
    public int randomx;
    public SpriteRenderer spt;
    public override void Completed()
    {
        if (spawner.rndmPos==0)
        {
            randomx = Random.Range(10,20);
        }
        else if(spawner.rndmPos == 1)
        {
            randomx = Random.Range(-10, -20);
        }
        transform.DOMove(new Vector2(randomx, 0), 1);
        Destroy(gameObject,1f);
    }

    public override Transform[] MovedTranform()
    {
        Transform[] result = new Transform[1];
        result[0] = transform;

        return result;
    }
}
