using UnityEngine;

public class Thorn : Enemy
{
    //public float enemyUp;

    public override void Completed()
    {
        Destroy(gameObject,1);
    }

    public override Transform[] MovedTranform()
    {
        Transform[] result = new Transform[transform.childCount];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = transform.GetChild(i);
        }

        return result;
    }
}
