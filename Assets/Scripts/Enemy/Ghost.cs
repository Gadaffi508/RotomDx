using UnityEngine;

public class Ghost : Enemy
{
    public GameObject attackObject;

    public override void Completed()
    {
        InstantAttackObject();
        Destroy(gameObject);
    }

    public void InstantAttackObject()
    {
            Instantiate(attackObject, transform.position, Quaternion.identity);
    }

    public override Transform[] MovedTranform()
    {
        Transform[] result = new Transform[1];
        result[0] = transform;

        return result;
    }
}
