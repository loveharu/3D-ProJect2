using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public EnemyHealthBar enemyHealthBar;
    public int maxHealth = 100;
    public int currentHealth;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        enemyHealthBar.UpdateHealth();
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died!");
        bool isEnemy = gameObject.TryGetComponent(out Enemy enemy);
        if (isEnemy)
        {
            enemy.isDead = true;
        }
        anim.SetTrigger("doDie");
    }
    
    void EndDeath()
    {
        Destroy(gameObject);
    }
}
