using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillDamage : MonoBehaviour
{
    // public LayerMask enemyLayer;    //enemylayer'ým player'a eþitse playerýn caný hasar alacak, diðerlerinde de kime eþitse o hasar alacak... ona göre ayarlýyoruz...
    // public float radius = 0.5f;
    // public float damageCount = 10f;

    // private EnemyHealth enemyHealth;
    // private PlayerHealth playerHealth;
    // protected bool collided;
    //internal virtual void Update()
    // {                                                   //burda þöyle bir þey demiþ oluyoruz; radius yarýçaplý bir küre yarat ve bu küreyi transform.position(attach ettiðimiz nesnenin pozisyonunda) yarat diyoruz ve
    //     Collider[] hits = Physics.OverlapSphere(transform.position, radius, enemyLayer);    //ve enemy layer'ý olan ve collider'ý olan herhangi bir obje bunun içine girerse bu hits adlý array'e eklenecektir.

    //     foreach (Collider hit in hits)  //isabet ettirdiðimiz herbir enemy için...
    //     {
    //         if (enemyLayer==(1<<LayerMask.NameToLayer("Enemy")))    //<< operatörü bitmask olayýyla alakalý... 1<<12 demek burasý...12 ise enemy layer'ý layer listesinde...
    //         {
    //             enemyHealth = hit.gameObject.GetComponent<EnemyHealth>();       //skilin isabet ettiði tüm enemyler hasarý yesin diye...
    //             collided = true;
    //         }

    //        else  if (enemyLayer == (1 << LayerMask.NameToLayer("Player")))    //<< operatörü bitmask olayýyla alakalý... 1<<12 demek burasý...12 ise enemy layer'ý layer listesinde...
    //         {
    //             playerHealth = hit.gameObject.GetComponent<PlayerHealth>();       //skilin isabet ettiði tüm enemyler hasarý yesin diye...
    //             collided = true;
    //         }

    //         if (collided)   //enemy'e çarparsak/vurursak çalýþýyor
    //         {
    //             if (enemyLayer == (1 << LayerMask.NameToLayer("Enemy")))    //<< operatörü bitmask olayýyla alakalý... 1<<12 demek burasý...12 ise enemy layer'ý layer listesinde...
    //             {
    //                 if (enemyHealth!=null)
    //                 {
    //                     enemyHealth.TakeDamage(damageCount);
    //                     enabled = false;
    //                 }

    //             }

    //             else if (enemyLayer == (1 << LayerMask.NameToLayer("Player")))    //<< operatörü bitmask olayýyla alakalý... 1<<12 demek burasý...12 ise enemy layer'ý layer listesinde...
    //             {
    //                 if (enemyHealth!=null)
    //                 {
    //                     playerHealth.TakeDamage(damageCount);
    //                     enabled = false;
    //                 }

    //             }


    //         }
    //     }

    // }
    // private void OnDrawGizmos()
    // {
    //     Gizmos.color = Color.red;
    //     Gizmos.DrawWireSphere(transform.position, radius);
    // }






    public LayerMask enemyLayer;
    public float radius = 0.5f;
    public float damageCount = 10f;
    private EnemyHealth enemyHealth;
    private PlayerHealth playerHealth;
    protected bool colided;
    internal virtual void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, radius, enemyLayer);
        foreach (Collider hit in hits)
        {
            if (enemyLayer == (1 << LayerMask.NameToLayer("Enemy")))
            {
                enemyHealth = hit.gameObject.GetComponent<EnemyHealth>();
                colided = true;
            }
            else if (enemyLayer == (1 << LayerMask.NameToLayer("Player")))
            {
                playerHealth = hit.gameObject.GetComponent<PlayerHealth>();
                colided = true;
            }
            if (colided)
            {
                if (enemyLayer == (1 << LayerMask.NameToLayer("Enemy")))
                {
                    if (enemyHealth != null)
                    {
                        enemyHealth.TakeDamage(damageCount);
                        enabled = false;
                    }
                }
                else if (enemyLayer == (1 << LayerMask.NameToLayer("Player")))
                {
                    if (playerHealth != null)
                    {
                        playerHealth.TakeDamage(damageCount);
                        enabled = false;
                    }
                }
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
