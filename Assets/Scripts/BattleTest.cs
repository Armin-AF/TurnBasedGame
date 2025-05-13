using UnityEngine;

public class BattleTest : MonoBehaviour
{
    public Player player;
    public Enemy enemy;

    void Start()
    {
        Debug.Log("Starting Battle Test...");
        
        // Simulate an attack
        enemy.AttackPlayer(player);
        player.TakeDamage(10);
        player.Heal(20);
    }
}