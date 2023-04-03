using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    PlayerHealth plhealth;
    public int damage;

    void Start()
    {
        plhealth = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<PlayerHealth>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            plhealth.PlayerTakeDamage(damage);
        }
    }
}
