using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossState : MonoBehaviour
{
    //public enum State
    //{
    //    NONE,
    //    SLEEP,
    //    PATROL,
    //    CHASE,
    //    ATTACK,
    //    SHOOT,
    //    DEATH
    //}
    //private Transform playerTarget;
    //private State bossState = State.NONE;

    //public State state { get { return bossState; } }

    //private float distanceToTarget;

    //private EnemyHealth enemyHealth;

    //private void Awake()
    //{
    //    playerTarget = GameObject.FindGameObjectWithTag("Player").transform;
    //    enemyHealth = GetComponent<EnemyHealth>();
    //    bossState = State.SLEEP;
    //}
    //private void Update()
    //{
    //    SetState();
    //}
    //private void SetState()
    //{
    //      distanceToTarget=Vector3.Distance(transform.position, playerTarget.position); //boss ile oyuncu arasýndaki mesafe  

    //    if (bossState == State.SLEEP)
    //    {
    //        int enemyCount = FindObjectsOfType<EnemyWayPointTracker>().Length;
    //        if (enemyHealth.currentHealth < enemyHealth.maxHealth) 
    //        {
    //            bossState = State.NONE;
    //        }
    //        else if (distanceToTarget<=4)
    //        {
    //            bossState = State.NONE;
    //        }
    //        else if (enemyCount<=0)
    //        {
    //            bossState = State.NONE;
    //        }
    //        else
    //        {
    //            bossState= State.SLEEP;  
    //        }
    //    }
    //    else if (bossState!=State.DEATH || bossState!=State.SLEEP)
    //    {
    //        if (distanceToTarget>4f&&distanceToTarget<=8f)
    //        {
    //            bossState = State.CHASE;
    //        }
    //        else if (distanceToTarget>8f&&distanceToTarget<=12f)
    //        {
    //            bossState = State.SHOOT;
    //        }
    //        else if ( distanceToTarget >12f)
    //        {
    //            bossState = State.PATROL;
    //        }
    //        else if ( distanceToTarget <4f)
    //        {
    //            bossState = State.ATTACK;
    //        }
    //        else
    //        {
    //            bossState= State.NONE;
    //        }
    //    }
    //    if (enemyHealth.currentHealth<=0f)
    //    {
    //        bossState = State.DEATH;
    //    }
    //}


    public enum State
    {
        NONE,
        SLEEP,
        PATROL,
        CHASE,
        ATTACK,
        SHOOT,
        DEATH
    }

    private Transform playerTarget;
    private State bossState = State.SLEEP;
    public State state { get { return bossState; } }

    private float distanceTotarget;

    private EnemyHealth enemyHealth;

    private void Awake()
    {
        playerTarget = GameObject.FindGameObjectWithTag("Player").transform;
        enemyHealth = GetComponent<EnemyHealth>();
        bossState = State.SLEEP;
    }
    private void Update()
    {
        SetState();
    }
    void SetState()
    {
        distanceTotarget = Vector3.Distance(transform.position, playerTarget.position);

        if (bossState == State.SLEEP)
        {
            int enemyCount = FindObjectsOfType<EnemyWayPointTracker>().Length;
            if (enemyHealth.currentHealth < enemyHealth.maxHealth)
            {
                bossState = State.NONE;
            }
            else if (distanceTotarget <= 4f)
            {
                bossState = State.NONE;
            }
            else if (enemyCount <= 0)
            {
                bossState = State.NONE;
            }
            else
            {
                bossState = State.SLEEP;
            }
        }
        else if (bossState != State.DEATH || bossState != State.SLEEP)
        {
            if (distanceTotarget > 4f && distanceTotarget <= 8f)
            {
                bossState = State.CHASE;
            }
            else if (distanceTotarget > 8f && distanceTotarget <= 12f)
            {
                bossState = State.SHOOT;
            }
            else if (distanceTotarget > 12f)
            {
                bossState = State.PATROL;
            }
            else if (distanceTotarget <= 4f)
            {
                bossState = State.ATTACK;
            }
            else
            {
                bossState = State.NONE;
            }
        }
        if (enemyHealth.currentHealth <= 0f)
        {
            bossState = State.DEATH;
        }
    }
}
