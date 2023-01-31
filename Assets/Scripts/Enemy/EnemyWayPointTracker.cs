using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyWayPointTracker : MonoBehaviour
{   //burda yapaca��m�z olay, yapay zekam�z�n devriye atmas� olay�

    //[Header("Waypoints")]
    //public Transform[] walkPoints;
    //[Header("Movement Settings")]
    //public float turnSpeed = 5f;
    //public float patrolTime = 3f;
    //public float walkDistance = 8f;
    //[Header("Attack Settings")]
    //public float attackDistance = 1.4f;
    //public float attackRate = 1f;

    //private Transform playerTarget;
    //private Animator anim;

    //private NavMeshAgent agent;

    //private float currentATtackTime;

    //private Vector3 nextDestination;
    //private int index;

    //EnemyHealth enemyHealth;

    //private void Awake()
    //{
    //    playerTarget = GameObject.FindGameObjectWithTag("Player").transform;
    //    anim = GetComponent<Animator>();
    //    agent = GetComponent<NavMeshAgent>();
    //    enemyHealth= GetComponent<EnemyHealth>();   //b�ylece d��man�n can�n� ne kadar oldu�unu g�rebilece�iz
    //    index = Random.Range(0, walkPoints.Length);
    //    if (walkPoints.Length>0)
    //    {
    //        InvokeRepeating("Petrol", Random.Range(0, patrolTime), patrolTime); //ilk parametre kadar bekle, ikinci parametre s�resince patrol at
    //    }
    //}

    //void Start()
    //{
    //    agent.avoidancePriority = Random.Range(1, 51);
    //}


    //void Update()
    //{
    //    if (enemyHealth.currentHealth>0)
    //    {
    //        MoveAndAttack();
    //    }
    //    else
    //    {
    //        anim.ResetTrigger("Hit");
    //        anim.SetBool("Death", true);
    //        AudioManager.instance.PlaySfx(5);
    //        agent.enabled = false;  //nav mesh agent'� kapat�yor
    //        if (!anim.IsInTransition(0)&&anim.GetCurrentAnimatorStateInfo(0).IsTag("Die")&&anim.GetCurrentAnimatorStateInfo(0).normalizedTime>0.95f)       //enemy'i yok etmek i�in
    //        {
    //            Destroy(this.gameObject, 3f);
    //        }
    //    }



    //}

    //void MoveAndAttack()
    //{
    //    float distance = Vector3.Distance(transform.position, playerTarget.position);
    //    if (distance>walkDistance)  //y�r�meye devam
    //    {
    //        if (agent.remainingDistance>=agent.stoppingDistance)
    //        {
    //            agent.isStopped = false;
    //            agent.speed = 2f;
    //            anim.SetBool("Walk", true);
    //            nextDestination = walkPoints[index].position;
    //            agent.SetDestination(nextDestination);
    //        }
    //        else
    //        {
    //            agent.isStopped = true;
    //            agent.speed = 0f;
    //            anim.SetBool("Walk", false);

    //            nextDestination = walkPoints[index].position;
    //            agent.SetDestination(nextDestination);
    //        }

    //    }
    //    else    //distance<walkDistance olunca sald�r�ya ge�memiz laz�m
    //    {
    //        if (distance>attackDistance+0.15f && playerTarget.GetComponent<PlayerHealth>().currentHealth>0)
    //        {
    //            if (!anim.IsInTransition(0)&&!anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
    //            {
    //                anim.ResetTrigger("Attack");
    //                agent.isStopped = false;
    //                agent.speed = 3f;       //birnevi g�r�� rangei i�ine girdi�i i�in art�k daha h�zl� kovalamaya ba�las�n diyoruz.
    //                anim.SetBool("Walk", true);

    //                agent.SetDestination(playerTarget.position);    //oyuncuyu kovala
    //            }

    //        }
    //        else if (distance<=attackDistance && playerTarget.GetComponent<PlayerHealth>().currentHealth>0) //buray� anim.getbool(death,true) falan �eklinde de olabilir mi ?? denenur...
    //        {
    //            agent.isStopped = true;
    //            anim.SetBool("Walk", false);
    //            agent.speed = 0;
    //            Vector3 targetPosition = new Vector3(playerTarget.position.x, transform.position.y, playerTarget.position.z);

    //            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetPosition - transform.position), turnSpeed * Time.deltaTime);

    //            if (currentATtackTime>=attackRate)  //bu ve else kondisyonu, iki sald�r� aras� zaman� ayarl�yor bir nevi ve sald�r emrini veriyor
    //            {
    //                anim.SetTrigger("Attack");
    //                AudioManager.instance.PlaySfx(2);
    //                currentATtackTime = 0;
    //            }
    //            else
    //            {
    //                currentATtackTime += Time.deltaTime;    
    //            }
    //        }
    //    }
    //}
    //void Patrol()
    //{   
    //    index=index==walkPoints.Length-1 ? 0 : index+1;
    //    //if (index==walkPoints.Length-1)
    //    //{
    //    //    index = 0;
    //    //}
    //    //else
    //    //{
    //    //    index += 1;
    //    //}
    //}





    [Header("Waypoints")]
    public Transform[] walkPoints;
    [Header("Movement Settings")]
    public float turnSpeed = 5f;
    public float patrolTime = 10f;
    public float walkDistance = 8f;
    [Header("Attack Settings")]
    public float attackDistance = 1.4f;
    public float attackRate = 1f;

    private Transform playerTarget;
    private Animator anim;

    private NavMeshAgent agent;

    private float currentAttackTime;

    private Vector3 nextDestination;
    private int index;

    //Health
    EnemyHealth enemyHealth;
    private void Awake()
    {
        playerTarget = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        enemyHealth = GetComponent<EnemyHealth>();
        index = Random.Range(0, walkPoints.Length);
        if (walkPoints.Length > 0)
        {
            InvokeRepeating("Patrol", Random.Range(0, patrolTime), patrolTime);
        }
    }
    void Start()
    {
        agent.avoidancePriority = Random.Range(1, 51);

    }
    void Update()
    {
        if (enemyHealth.currentHealth > 0)
        {
            MoveAndAttack();
        }
        else
        {
            anim.ResetTrigger("Hit");
            anim.SetBool("Death", true);
            AudioManager.instance.PlaySfx(5);
            agent.enabled = false;
            if (!anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsTag("Die") &&
                anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.95f)
            {
                Destroy(this.gameObject, 5);
            }
        }

    }
    void MoveAndAttack()
    {
        float distance = Vector3.Distance(transform.position, playerTarget.position);
        if (distance > walkDistance)
        {
            if (agent.remainingDistance >= agent.stoppingDistance)
            {
                agent.isStopped = false;
                agent.speed = 2f;
                anim.SetBool("Walk", true);

                nextDestination = walkPoints[index].position;
                agent.SetDestination(nextDestination);
            }
            else
            {
                agent.isStopped = true;
                agent.speed = 0;
                anim.SetBool("Walk", false);

                nextDestination = walkPoints[index].position;
                agent.SetDestination(nextDestination);
            }
        }
        else
        {
            if (distance > attackDistance + 0.15f && playerTarget.GetComponent<PlayerHealth>().currentHealth > 0)
            {
                if (!anim.IsInTransition(0) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
                {
                    anim.ResetTrigger("Attack");
                    agent.isStopped = false;
                    agent.speed = 3f;
                    anim.SetBool("Walk", true);
                    agent.SetDestination(playerTarget.position);
                }
            }
            else if (distance <= attackDistance && playerTarget.GetComponent<PlayerHealth>().currentHealth > 0)
            {
                agent.isStopped = true;
                anim.SetBool("Walk", false);
                agent.speed = 0;
                Vector3 targetPosition = new Vector3(playerTarget.position.x,
                    transform.position.y, playerTarget.position.z);

                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetPosition - transform.position),
                    turnSpeed * Time.deltaTime);

                if (currentAttackTime >= attackRate)
                {
                    anim.SetTrigger("Attack");
                    AudioManager.instance.PlaySfx(2);
                    currentAttackTime = 0;
                }
                else
                {
                    currentAttackTime += Time.deltaTime;
                }

            }
        }
    }
    void Patrol()
    {
        index = index == walkPoints.Length - 1 ? 0 : index + 1;
    }
}
