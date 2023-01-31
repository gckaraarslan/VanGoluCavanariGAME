using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    //private int currentExp;
    //private int level;
    //private int expToNextLevel;

    //public int GetLevel { get { return level+1; } }
    //public static LevelManager instance;    //static bunu ram'de tutmam�z� sa�l�yor, her yerden her classtan ula�abiliyoruz... nesne olu�turmaya gerek yok direkt LevelManager.instance �eklinde yapabiliyoruz...
    //                                        //�r: playeronclick'te LevelManager.instance.currentExp diyerek ula�abiliriz... dezavantaj� da; �rn; enemy'nin can�n� public static healthenemy=10 dedik, enemy can� 0 olunca �ls�n dedi�imizde bundan olan t�m enemyler �l�r...

    //public Image Expbar;
    //public Text LevelText;

    //public GameObject LevelUpVFX;
    //private Transform Player;



    //private void Awake()
    //{
    //    if (instance=null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //    level = 0;
    //    currentExp = 0;
    //    expToNextLevel= 100;
    //    Expbar.fillAmount= 0f;
    //    UpdateLevelText();
    //    Player = GameObject.Find("Player").gameObject.transform;
    //}

    //private void Update()
    //{

    //}
    //public void AddExp(int amount)
    //{
    //    currentExp += amount;
    //    Expbar.fillAmount = (float)currentExp/expToNextLevel;
    //    if (currentExp>=expToNextLevel) 
    //    {
    //        level++;
    //        GameObject LevelUpVFXClone= Instantiate(LevelUpVFX, transform.position, Quaternion.identity);   //bu iki sat�r... bu effect...
    //        LevelUpVFXClone.transform.SetParent(Player);                                                        //bizi takip etsin diye
    //        UpdateLevelText();
    //        currentExp -= expToNextLevel;
    //        Expbar.fillAmount= 0f;
    //    }
    //} 

    //private void UpdateLevelText()
    //{
    //     LevelText.text=GetLevel.ToString();
    //}

    //private void OnEnable()
    //{
    //    EnemyHealth.onDeath += AddExp;  //ondeath eventini addexp metoduna ba�la diyoruz....    bir enemy �l�nce ondeath triggerlancak, expamount kadar de�eri burda addexp'in parametre k�sm�na giricek,�al��acak metod...
    //}
    //private void OnDisable()    //eeventlerdeki bir problem: obje(enemy) yok olursa event buna eri�meye �al��maya devam ediyor.S�rekli olarak veri istiyor ondan, bunu engellemek i�in de ondisable kullan�yoruz...
    //{
    //    EnemyHealth.onDeath -= AddExp;
    //}

        
    /// <summary>
    /// //////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    private int currentExp;
    private int level;
    private int expToNextLevel;
    public int GetLevel { get { return level + 1; } }
    public static LevelManager instance;

    public Image ExpBar;
    public Text LevelText;

    public GameObject LevelUpVFX;
    private Transform Player;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        level = 0;
        currentExp = 0;
        expToNextLevel = 50;
        ExpBar.fillAmount = 0f;
        UpdateLevelText();
        Player = GameObject.Find("Player").gameObject.transform;
    }


    public void AddExp(int amount)
    {
        currentExp += amount;
        ExpBar.fillAmount = (float)currentExp / expToNextLevel;
        if (currentExp >= expToNextLevel)
        {
            level++;
            GameObject LevelUpVFXClone = Instantiate(LevelUpVFX, Player.position, Quaternion.identity);
            LevelUpVFXClone.transform.SetParent(Player);
            UpdateLevelText();
            currentExp -= expToNextLevel;
            ExpBar.fillAmount = 0f;
        }
    }
    void UpdateLevelText()
    {
        LevelText.text = GetLevel.ToString();
    }
    private void OnEnable()
    {
        EnemyHealth.onDeath += AddExp;
    }
    private void OnDisable()
    {
        EnemyHealth.onDeath -= AddExp;
    }
}
