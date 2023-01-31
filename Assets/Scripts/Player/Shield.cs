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
    private void OnEnable() //unitynin bize verdi�i bu iki metod...bu obje sahneye ilk girdi�i anda �al��r
    {
        playerHealth.Shielded = true;
    }
    private void OnDisable()    //obje tam kapanmadan �nce �al���r
    {
        playerHealth.Shielded = false;
    }
}
