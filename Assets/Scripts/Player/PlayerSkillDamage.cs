using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillDamage : MonoBehaviour
{
    // public LayerMask enemyLayer;    //enemylayer'�m player'a e�itse player�n can� hasar alacak, di�erlerinde de kime e�itse o hasar alacak... ona g�re ayarl�yoruz...
    // public float radius = 0.5f;
    // public float damageCount = 10f;

    // private EnemyHealth enemyHealth;
    // private PlayerHealth playerHealth;
    // protected bool collided;
    //internal virtual void Update()
    // {                                                   //burda ��yle bir �ey demi� oluyoruz; radius yar��apl� bir k�re yarat ve bu k�reyi transform.position(attach etti�imiz nesnenin pozisyonunda) yarat diyoruz ve
    //     Collider[] hits = Physics.OverlapSphere(transform.position, radius, enemyLayer);    //ve enemy layer'� olan ve collider'� olan herhangi bir obje bunun i�ine girerse bu hits adl� array'e eklenecektir.

    //     foreach (Collider hit in hits)  //isabet ettirdi�imiz herbir enemy i�in...
    //     {
    //         if (enemyLayer==(1<<LayerMask.NameToLayer("Enemy")))    //<< operat�r� bitmask olay�yla alakal�... 1<<12 demek buras�...12 ise enemy layer'� layer listesinde...
    //         {
    //             enemyHealth = hit.gameObject.GetComponent<EnemyHealth>();       //skilin isabet etti�i t�m enemyler hasar� yesin diye...
    //             collided = true;
    //         }

    //        else  if (enemyLayer == (1 << LayerMask.NameToLayer("Player")))    //<< operat�r� bitmask olay�yla alakal�... 1<<12 demek buras�...12 ise enemy layer'� layer listesinde...
    //         {
    //             playerHealth = hit.gameObject.GetComponent<PlayerHealth>();       //skilin isabet etti�i t�m enemyler hasar� yesin diye...
    //             collided = true;
    //         }

    //         if (collided)   //enemy'e �arparsak/vurursak �al���yor
    //         {
    //             if (enemyLayer == (1 << LayerMask.NameToLayer("Enemy")))    //<< operat�r� bitmask olay�yla alakal�... 1<<12 demek buras�...12 ise enemy layer'� layer listesinde...
    //             {
    //                 if (enemyHealth!=null)
    //                 {
    //                     enemyHealth.TakeDamage(damageCount);
    //                     enabled = false;
    //                 }

    //             }

    //             else if (enemyLayer == (1 << LayerMask.NameToLayer("Player")))    //<< operat�r� bitmask olay�yla alakal�... 1<<12 demek buras�...12 ise enemy layer'� layer listesinde...
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
