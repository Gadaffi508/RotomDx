using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health=100;
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void PlayerTakeDamage(int damage)
    {
        health -= damage;
        anim.SetTrigger("hurt");
        if (damage <=0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Öldün");
    }

}
