using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    private bool isAttacking = false;
    public Animator animator;
    public Transform attackPoint;
    [SerializeField] public float attackRange;
    public LayerMask enemyLayers;
    public HealthSystem healthSystem;
    [SerializeField] public int attackDamage;
    public AttackSystem attackSystem;
    private float cooldown = 1f;
    private float lastAttackTime = 0f;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Attack();
        }
    }

    private void Attack()
    {
        if (Time.time - lastAttackTime < cooldown) return;
        if (!isAttacking)
        {
            isAttacking = true;

            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
            foreach(Collider2D Enemy in hitEnemies)
            {
                Debug.Log("Enemy hit: " + Enemy.name);
                healthSystem = Enemy.gameObject.GetComponent<HealthSystem>();
                healthSystem.TakeDamage(attackDamage);
            }
            lastAttackTime = Time.time;
            isAttacking = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null) return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
