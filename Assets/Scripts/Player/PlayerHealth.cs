using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [HideInInspector] public float currentHealth;
    public float maxHealth=100f;
    private bool isShielded = false;
    public bool Shielded { get { return isShielded; } set { isShielded = value; } }

    private Animator anim;

    private Image healthImage;


    public void UpdateHealth()
    {
        healthImage.fillAmount=currentHealth/maxHealth;
    }

    private void Awake()
    {
        currentHealth = maxHealth;
        anim=GetComponent<Animator>();
        healthImage = GameObject.Find("HealthOrb").GetComponent<Image>();
    }
    public void TakeDamage(float amount)
    {
        if (!isShielded)
        {
            currentHealth -= amount;
            UpdateHealth();
            if (currentHealth<=0)
            {
                anim.SetBool("Death", true);
            }
        }
    }
    public void HealPlayer(float amount)
    {
        currentHealth+= amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealth();
    }

}
