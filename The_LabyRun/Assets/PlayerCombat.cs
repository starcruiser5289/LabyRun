using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public static bool IsArmed = false;
    public Animator animCombat;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsArmed)
        {
            Attack();
        }
    }
    void Attack()
    {
        animCombat.SetTrigger("Attack");
        Collider2D[] hitEnemies  = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (var enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
        }
    }
}
