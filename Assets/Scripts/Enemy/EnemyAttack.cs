using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //public float damage = 5f;
    //private void OnTriggerEnter(Collider other) //box collider'�n( i�ine other(player)) girdi�i anda other player'�m�z�n referans� oluyor
    //{
    //    PlayerHealth playerHealth = other.GetComponent<PlayerHealth>(); //other=player
    //    if (playerHealth!=null)
    //    {
    //        playerHealth.TakeDamage(damage);
    //    }
        
    //}

    public float damage = 10;
    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }
    }






    //private void OnTriggerStay(Collider other)  //update gibi, i�inde kald��� s�rece
    //{

    //}

    //private void OnTriggerExit(Collider other)  //disable gibi...                                             //bunlar� kullanm�yoruz ama....
    //{

    //}
    //private void OnCollisionEnter(Collision collision)  //�al��abilmesi i�in isTrigger'�n kapal� olmas� gerekiyor.
    //{

    //}
}
