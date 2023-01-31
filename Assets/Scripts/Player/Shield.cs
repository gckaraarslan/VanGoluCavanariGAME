using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    PlayerHealth playerHealth;
    private void Awake()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }
    private void OnEnable() //unitynin bize verdiði bu iki metod...bu obje sahneye ilk girdiði anda çalýþr
    {
        playerHealth.Shielded = true;
    }
    private void OnDisable()    //obje tam kapanmadan önce çalýþýr
    {
        playerHealth.Shielded = false;
    }
}
