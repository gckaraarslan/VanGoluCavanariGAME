using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; //eventleri kullanabilmek i�in using system a��yorz...

public class EnemyHealth : MonoBehaviour
{
    [HideInInspector] public float currentHealth;
    Animator anim;

    public float maxHealth = 100f;
    [SerializeField] private Image EnemyHealthBar;
     private SphereCollider targetCollider; //�ld���m�zde targetcollider'� kapatal�m... 

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
        if (currentHealth > 0)    //�ld���nde bu kod �al��mas�n diye...
        {
            if (this.gameObject.tag=="Boss")
            {
                AudioManager.instance.PlaySfx(6);
            }
            else if (this.gameObject.tag=="Enemy")
            {
                AudioManager.instance.PlaySfx(3);
            }
            anim.SetTrigger("Hit"); //take damage olunca, bu animator/animasyon �al��s�n
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
                canvas.gameObject.SetActive(false);             //iskelet �ld���nde bu iki sat�r kod ile �st�ndeki health bar yok olacak.
            }
       
        }
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage(5);
        //    print(currentHealth);   // TEST AMA�LI A�ILAB�L�R...
        //}


    }


}
