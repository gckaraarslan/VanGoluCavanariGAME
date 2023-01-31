using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //public float damage = 5f;
    //private void OnTriggerEnter(Collider other) //box collider'ýn( içine other(player)) girdiði anda other player'ýmýzýn referansý oluyor
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






    //private void OnTriggerStay(Collider other)  //update gibi, içinde kaldýðý sürece
    //{

    //}

    //private void OnTriggerExit(Collider other)  //disable gibi...                                             //bunlarý kullanmýyoruz ama....
    //{

    //}
    //private void OnCollisionEnter(Collision collision)  //çalýþabilmesi için isTrigger'ýn kapalý olmasý gerekiyor.
    //{

    //}
}
