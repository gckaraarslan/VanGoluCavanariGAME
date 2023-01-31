using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; //eventleri kullanabilmek için using system açýyorz...

public class EnemyHealth : MonoBehaviour
{
    [HideInInspector] public float currentHealth;
    Animator anim;

    public float maxHealth = 100f;
    [SerializeField] private Image EnemyHealthBar;
     private SphereCollider targetCollider; //öldüðümüzde targetcollider'ý kapatalým... 

    public int ExpAmount = 200;
    public static event Action<int> onDeath;

    private void Awake()
    {
        currentHealth = maxHealth;
        targetCollider=GetComponentInChildren<SphereCollider>();
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(float amount)
    {    
        currentHealth -= amount;
        EnemyHealthBar.fillAmount = currentHealth / maxHealth;
        if (currentHealth > 0)    //öldüðünde bu kod çalýþmasýn diye...
        {
            if (this.gameObject.tag=="Boss")
            {
                AudioManager.instance.PlaySfx(6);
            }
            else if (this.gameObject.tag=="Enemy")
            {
                AudioManager.instance.PlaySfx(3);
            }
            anim.SetTrigger("Hit"); //take damage olunca, bu animator/animasyon çalýþsýn
        }
        if (currentHealth<=0)
        {
            Canvas canvas = EnemyHealthBar.gameObject.GetComponentInParent<Canvas>();
            onDeath(ExpAmount);
            if (targetCollider.gameObject.activeInHierarchy)
            {
                targetCollider.gameObject.SetActive(false);
            }
           
            if (canvas.gameObject.activeInHierarchy)
            {
                canvas.gameObject.SetActive(false);             //iskelet öldüðünde bu iki satýr kod ile üstündeki health bar yok olacak.
            }
       
        }
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage(5);
        //    print(currentHealth);   // TEST AMAÇLI AÇILABÝLÝR...
        //}


    }


}
