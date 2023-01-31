using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicAttack : MonoBehaviour
{
    public float damage = 10f;

    private void OnTriggerEnter(Collider other)
    {
        EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
        if (enemyHealth!=null)
        {                                                                                   //burdan sonra Animation k�sm�nda ayarlama yap�yoruz
            enemyHealth.TakeDamage(damage);
        }
    }
}
