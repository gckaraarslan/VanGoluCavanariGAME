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
    //public static LevelManager instance;    //static bunu ram'de tutmamýzý saðlýyor, her yerden her classtan ulaþabiliyoruz... nesne oluþturmaya gerek yok direkt LevelManager.instance þeklinde yapabiliyoruz...
    //                                        //ör: playeronclick'te LevelManager.instance.currentExp diyerek ulaþabiliriz... dezavantajý da; örn; enemy'nin canýný public static healthenemy=10 dedik, enemy caný 0 olunca ölsün dediðimizde bundan olan tüm enemyler ölür...

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
    //        GameObject LevelUpVFXClone= Instantiate(LevelUpVFX, transform.position, Quaternion.identity);   //bu iki satýr... bu effect...
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
    //    EnemyHealth.onDeath += AddExp;  //ondeath eventini addexp metoduna baðla diyoruz....    bir enemy ölünce ondeath triggerlancak, expamount kadar deðeri burda addexp'in parametre kýsmýna giricek,çalýþacak metod...
    //}
    //private void OnDisable()    //eeventlerdeki bir problem: obje(enemy) yok olursa event buna eriþmeye çalýþmaya devam ediyor.Sürekli olarak veri istiyor ondan, bunu engellemek için de ondisable kullanýyoruz...
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
