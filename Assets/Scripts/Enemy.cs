using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 50;
    private int currentHealth;

    void Start()
    {
        // Set enemy health to max at the start
        currentHealth = maxHealth;
        Debug.Log("Enemy Health: " + currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Enemy took " + damage + " damage. Current Health: " + currentHealth);
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Enemy is dead!");
        // You can add an explosion effect or respawn logic here
        Destroy(gameObject);
    }

    public void AttackPlayer(Player player)
    {
        int damage = Random.Range(5, 15);
        player.TakeDamage(damage);
        Debug.Log("Enemy attacks player for " + damage + " damage.");
    }
}