using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSkillCast : MonoBehaviour
{
    //[Header("Mana Settings")]
    //public float totalMana = 100f;
    //public float manaRegenSpeed = 2f;
    //private Image manaBar;

    //[Header("Cooldown Icons")]
    //public Image[] CooldownIcon;
    //[Header("Out Of Mana Icons")]
    //public Image[] OutOfManaIcons;
    //[Header("Cooldown Times")]
    //// public float[] coolDownTime; diyip dizili �ekilde de yap�labilir ama ben �imdilik amelemasyon yap�cam....
    //public float CooldownTime1 = 1f;
    //public float CooldownTime2 = 1f;
    //public float CooldownTime3 = 1f;
    //public float CooldownTime4 = 1f;
    //public float CooldownTime5 = 1f;
    //public float CooldownTime6 = 1f;

    //[Header("Mana Amounts")]
    //public float Skill1ManaAmount = 20f;
    //public float Skill2ManaAmount = 20f;
    //public float Skill3ManaAmount = 20f;
    //public float Skill4ManaAmount = 20f;
    //public float Skill5ManaAmount = 20f;
    //public float Skill6ManaAmount = 20f;

    //[Header("Required Level")]  //for d�ng�s�ne alabilmek i�in bunlar� listeye al�caz a�a��da
    //public int Skill1 = 2;
    //public int Skill2 = 3;
    //public int Skill3 = 4;
    //public int Skill4 = 5;
    //public int Skill5 = 6;
    //public int Skill6 = 7;






    //private bool canAttack = true;
    //private bool faded=false;   //bunu yazma nedenimiz; soldu�u zaman,iconumuz tekrardan siyah oldu�u zaman faded=true olacak,  (fillamount=1)
    //                            //bu true olunca fillamoount 1'den 0'a do�ru gidecek, filamount=0 olunca faded=false olacak ve fillamount tekrardan 1 olacak

    //private int[] fadeImages = new int[] {0,0,0,0,0,0 }; //Imageleri int arrayliste al�yoruz... (fade =false yani fillamount=0)

    //[HideInInspector]public List<float> CoolDownTimesList= new List<float>(); 
    //private List<float> ManaAmountList=new List<float>();

    //private List<int> LevelList = new List<int>();



    //private Animator anim; //referans olarak animat�r� �ekiyorum
    //private PlayerOnClick playerOnClick;

    //private LevelManager levelManager;

    //private void Awake()
    //{
    //    anim= GetComponent<Animator>();
    //    playerOnClick= GetComponent<PlayerOnClick>();
    //    manaBar = GameObject.Find("ManaOrb").GetComponent<Image>(); //burda yapt���m�z i�lem; manaorb objesini bul ve bana Image Componentini getir ve manaBar yap
    //    //player i�indeki mana bar'�n oraya s�r�kleyebilirdik de...
    //    levelManager = FindObjectOfType<LevelManager>();
    //}


    //void Start()
    //{


    //    AddList();


    //}
    //void AddList()
    //{
    //    //CooldownListAdd
    //    CoolDownTimesList.Add(CooldownTime1);
    //    CoolDownTimesList.Add(CooldownTime2);
    //    CoolDownTimesList.Add(CooldownTime3);
    //    CoolDownTimesList.Add(CooldownTime4);
    //    CoolDownTimesList.Add(CooldownTime5);
    //    CoolDownTimesList.Add(CooldownTime6);
    //    //ManaAmountListAdd
    //    ManaAmountList.Add(Skill1ManaAmount);
    //    ManaAmountList.Add(Skill2ManaAmount);
    //    ManaAmountList.Add(Skill3ManaAmount);
    //    ManaAmountList.Add(Skill4ManaAmount);
    //    ManaAmountList.Add(Skill5ManaAmount);
    //    ManaAmountList.Add(Skill6ManaAmount);
    //    //level
    //    LevelList.Add(Skill1);
    //    LevelList.Add(Skill2);
    //    LevelList.Add(Skill3);
    //    LevelList.Add(Skill4);
    //    LevelList.Add(Skill5);
    //    LevelList.Add(Skill6);
    //}

    //void Update()
    //{
    //    if (!anim.IsInTransition(0)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))    //ge�i�te de�ilsek ve IDLE(durma veya y�r�medeysek,idle'�n i�inde ikisi de var bunda)
    //    {

    //        canAttack = true; 
    //    }
    //    else
    //    {
    //        canAttack= false;
    //    }

    //    if (anim.IsInTransition(0)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Idle")) //Idle'dan ge�i� an�na ge�ti�i o anda a�a��y� �al��t�r
    //    {
    //        TurnThePlayer();
    //    }

    //    if (totalMana<100f)
    //    {
    //        totalMana += Time.deltaTime * manaRegenSpeed;
    //        manaBar.fillAmount = totalMana / 100f;  //fillamount maximum 1 e e�it olabildi�i i�in
    //    }

    //    CheckLevel();
    //    CheckMana();
    //    CheckToFade();
    //    CheckInput();
    //}


    //private void CheckInput()   //animat�rleri dizerken ordaki exit time cart curt o k�s�mlardaki de�erlere bir daha bak videoda........................................................................
    //{
    //    if (anim.GetInteger("Attack") == 0)   //Animator i�inde(controller i�inde) Attack Parametresinin de�erini getir, e�er s�f�ra e�itse...
    //    {                                   //yani hi�bir �ey yapmad���m�z senaryo

    //      // playerOnClick.FinishedMovement = false; //aksiyon bitmi� mi hay�r...bu durumda da di�er skilleri basam�yoruz...
    //        if (!anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))       //e�er IDLE'daysak ve ge�i�te de�ilsek, yani sald�r�y� bitirdiysek;finishedmovement=true yap
    //        {
    //            playerOnClick.FinishedMovement = true; //aksiyon bitti
    //        }   //bir tu�a bas�nca skill bitene kadar hareket edemiyoruz. bunun altyap�s�n� yapt�k
    //    }
    //    //skill INPUT
    //    if (Input.GetKeyDown(KeyCode.Alpha1)&& totalMana >= Skill1ManaAmount && levelManager.GetLevel>=Skill1)
    //    {
    //        playerOnClick.TargetPosition=transform.position;    //target position'� bulundu�un nokta yap�yoruz ki hareketini durdurmak i�in
    //        if (playerOnClick.FinishedMovement && fadeImages[0]!=1&&canAttack)
    //        {
    //            totalMana = totalMana - Skill1ManaAmount;
    //            fadeImages[0] = 1;  //bu skili bugda gibi s�rekli basabilmemizi engellemek i�in yoksa �stteki ko�ul ge�erli olur ve s�rekli taktaktak basar�z, bu da olmaz....
    //            anim.SetInteger("Attack", 1);   //playercontrollerdaki Attack parametresinin de�erini 1'e e�itle
    //        }
    //    }
    //   else if (Input.GetKeyDown(KeyCode.Alpha2) && totalMana >= Skill2ManaAmount&&levelManager.GetLevel >= Skill2)
    //    {
    //        playerOnClick.TargetPosition = transform.position;    //target position'� bulundu�un nokta yap�yoruz ki hareketini durdurmak i�in
    //        if (playerOnClick.FinishedMovement && fadeImages[1] != 1 && canAttack)
    //        {
    //            totalMana = totalMana - Skill2ManaAmount;
    //            fadeImages[1] = 1;  //bu skili bugda gibi s�rekli basabilmemizi engellemek i�in yoksa �stteki ko�ul ge�erli olur ve s�rekli taktaktak basar�z, bu da olmaz....
    //            anim.SetInteger("Attack", 2);   //playercontrollerdaki Attack parametresinin de�erini 2'e e�itle
    //        }
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Alpha3) && totalMana >= Skill3ManaAmount && levelManager.GetLevel >= Skill3)
    //    {
    //        playerOnClick.TargetPosition = transform.position;    //target position'� bulundu�un nokta yap�yoruz ki hareketini durdurmak i�in
    //        if (playerOnClick.FinishedMovement && fadeImages[2] != 1 && canAttack)
    //        {
    //            totalMana = totalMana - Skill3ManaAmount;
    //            fadeImages[2] = 1;  //bu skili bugda gibi s�rekli basabilmemizi engellemek i�in yoksa �stteki ko�ul ge�erli olur ve s�rekli taktaktak basar�z, bu da olmaz....
    //            anim.SetInteger("Attack", 3);   //playercontrollerdaki Attack parametresinin de�erini 3'e e�itle
    //        }
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Alpha4) && totalMana >= Skill4ManaAmount && levelManager.GetLevel >= Skill4)
    //    {
    //        playerOnClick.TargetPosition = transform.position;    //target position'� bulundu�un nokta yap�yoruz ki hareketini durdurmak i�in
    //        if (playerOnClick.FinishedMovement && fadeImages[3] != 1 && canAttack)
    //        {
    //            totalMana = totalMana - Skill4ManaAmount;
    //            fadeImages[3] = 1;  //bu skili bugda gibi s�rekli basabilmemizi engellemek i�in yoksa �stteki ko�ul ge�erli olur ve s�rekli taktaktak basar�z, bu da olmaz....
    //            anim.SetInteger("Attack", 4);   //playercontrollerdaki Attack parametresinin de�erini 4'e e�itle
    //        }
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Alpha5) && totalMana >= Skill5ManaAmount && levelManager.GetLevel >= Skill5)
    //    {
    //        playerOnClick.TargetPosition = transform.position;    //target position'� bulundu�un nokta yap�yoruz ki hareketini durdurmak i�in
    //        if (playerOnClick.FinishedMovement && fadeImages[4] != 1 && canAttack)
    //        {
    //            totalMana = totalMana - Skill5ManaAmount;
    //            fadeImages[4] = 1;  //bu skili bugda gibi s�rekli basabilmemizi engellemek i�in yoksa �stteki ko�ul ge�erli olur ve s�rekli taktaktak basar�z, bu da olmaz....
    //            anim.SetInteger("Attack", 5);   //playercontrollerdaki Attack parametresinin de�erini 5'e e�itle
    //        }
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Alpha6) && totalMana >= Skill6ManaAmount)
    //    {
    //        playerOnClick.TargetPosition = transform.position;    //target position'� bulundu�un nokta yap�yoruz ki hareketini durdurmak i�in
    //        if (playerOnClick.FinishedMovement && fadeImages[5] != 1 && canAttack && levelManager.GetLevel >= Skill6)
    //        {   totalMana=totalMana- Skill6ManaAmount;
    //            fadeImages[5] = 1;  //bu skili bugda gibi s�rekli basabilmemizi engellemek i�in yoksa �stteki ko�ul ge�erli olur ve s�rekli taktaktak basar�z, bu da olmaz....
    //            anim.SetInteger("Attack", 6);   //playercontrollerdaki Attack parametresinin de�erini 6'e e�itle
    //        }
    //    }
    //    else
    //    {
    //        anim.SetInteger("Attack", 0);   // o da bizi en ba�a g�ndercek, orda e�er
    //    }

    //}





    //void CheckToFade()  //fadeImage'i ve fadeTime'� doldurabilmek i�in bu metodun i�inde FadeAndWait'i �a��r�yoruz
    //{
    //    for (int i = 0; i < CooldownIcon.Length; i++)
    //    {
    //        if (fadeImages[i] == 1)   //alpha1'e bast���m�zda fadeimages o indexi 1 e e�it olacak ve
    //        {
    //            if (FadeAndWait(CooldownIcon[i], CoolDownTimesList[i])) // Hangi resmi hangi s�rede k�saca��n� veriyoruz burda
    //            {
    //                fadeImages[i] = 0;                          //ve sonra bu fadeImage'in o indeksi 0'a e�itle tekrardan
    //            }
    //        }
    //    }

    //}    

    //void CheckMana()
    //{
    //    for (int i = 0; i < OutOfManaIcons.Length; i++)
    //    {
    //        if (levelManager.GetLevel >= LevelList[i])  //e�er skill i�in gerekli levelde de�ilsem hi� mana yetiyor mu yetmiyor mu kontrol dahi etme...
    //        {
    //            if (totalMana < ManaAmountList[i])
    //            {
    //                OutOfManaIcons[i].gameObject.SetActive(true);
    //            }
    //            else
    //            {
    //                OutOfManaIcons[i].gameObject.SetActive(false);
    //            }
    //        }

    //    }

    //}

    //void CheckLevel()
    //{
    //    for (int i = 0; i < OutOfManaIcons.Length; i++)
    //    {
    //        if (levelManager.GetLevel < LevelList[i])
    //        {
    //            OutOfManaIcons[i].gameObject.SetActive(true);   //b�ylelikle skil kararacak... (fillamount=1 olunca karar�yor ya onun gibi fill olmu� gibi) karartma image'� aktif hale geliyor yani
    //        }

    //    }
    //}

    //            //BURADA B�R TERSL�K VAR G�B�, �Y�CE OTURTMAM LAZIM                     
    //bool FadeAndWait(Image fadeImage,float fadeTime)  //solduysa true, solmad�ysa false almam�z laz�m bundan...Bu metodu bir yerden �a��rd���m�zda bizden bir image istiyecek
    //{                                   //bu sayede her skill att���m�zda o skilin IMAGE'ini �ekece�iz, onu siyaha �evirip �evirmedi�ini anlayaca��z
    //    faded = false;               //yani fillamount=0, skille bas�nca fillamount=1 olacak yani faded=trueya d�necek
    //    if (fadeImage == null)           //1-2-3 e falan bas�nca bir image gelmezse oyun ��kmesin diye...
    //    {
    //        return faded;
    //    }

    //    if (!fadeImage.gameObject.activeInHierarchy)    //Image'�n sol�st k��esi tikli de�ilse e�er...
    //    {
    //        fadeImage.gameObject.SetActive(true);       //oray� tikle demi� oluyoruz bir nevi...
    //        fadeImage.fillAmount = 1f;                  //bunla beraber fillamount=1 olmal� ki cd'ye girmi� olsun. 
    //    }

    //    fadeImage.fillAmount -= fadeTime * Time.deltaTime;

    //    if (fadeImage.fillAmount<=0f)   //s�f�ra ula�t���nda bunu(Image) kapat�yor faded'� true yap�yoruz.
    //    {
    //        fadeImage.gameObject.SetActive(false);  //Image'�n �stk��esindeki tiki kald�rd���n� d���n, yani fade �zelli�i iptal yani fillamount=0 gibi...
    //        faded = true;   //bunun false olmas� gerek miyor mu ?????? ��nk� fill amount s�f�ra e�itlendi...
    //    }
    //    return faded;   //burda true geldi�inde mesela, fadeandwait true gelmi� oluyor ya o da �sttechecktofade'de fadeimages[i]=0 yap�yor, o sayede de skill kullan�labilir hale geliyor tekrar
    //}

    //void TurnThePlayer()
    //{
    //    Vector3 targetPos = Vector3.zero;
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    RaycastHit hit;
    //    if (Physics.Raycast(ray,out hit))
    //    {
    //        targetPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
    //    }
    //    transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(targetPos-transform.position),playerOnClick.turnSpeed*Time.deltaTime);
    //}



    [Header("Mana Settins")]
    public float totalMana = 100f;
    public float manaRegenSpeed = 2f;
    private Image manaBar;
    [Header("Cooldown Icons")]
    public Image[] CooldownIcon;
    [Header("Out Of Mana Icons")]
    public Image[] OutOfManaIcons;
    [Header("Cooldown Times")]
    public float CooldownTime1 = 1f;
    public float CooldownTime2 = 1f;
    public float CooldownTime3 = 1f;
    public float CooldownTime4 = 1f;
    public float CooldownTime5 = 1f;
    public float CooldownTime6 = 1f;
    [Header("Mana Amounts")]
    public float Skill1ManaAmount = 20f;
    public float Skill2ManaAmount = 20f;
    public float Skill3ManaAmount = 20f;
    public float Skill4ManaAmount = 20f;
    public float Skill5ManaAmount = 20f;
    public float Skill6ManaAmount = 20f;
    [Header("Requierd level")]
    public int Skill1 = 2;
    public int Skill2 = 3;
    public int Skill3 = 4;
    public int Skill4 = 5;
    public int Skill5 = 6;
    public int Skill6 = 7;

    private bool faded = false;

    private int[] fadeImages = new int[] { 0, 0, 0, 0, 0, 0, };
    [HideInInspector] public List<float> CooldownTimesList = new List<float>();
    private List<float> ManaAmountList = new List<float>();
    private List<int> LevelList = new List<int>();
    private Animator anim;

    private bool canAttack = true;

    private PlayerOnClick playerOnClick;

    private LevelManager levelManager;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerOnClick = GetComponent<PlayerOnClick>();
        manaBar = GameObject.Find("ManaOrb").GetComponent<Image>();
        levelManager = FindObjectOfType<LevelManager>();
    }
    void Start()
    {
        AddList();
    }
    void AddList()
    {
        //CoolDownListAdd
        CooldownTimesList.Add(CooldownTime1);
        CooldownTimesList.Add(CooldownTime2);
        CooldownTimesList.Add(CooldownTime3);
        CooldownTimesList.Add(CooldownTime4);
        CooldownTimesList.Add(CooldownTime5);
        CooldownTimesList.Add(CooldownTime6);
        //ManaAmountList
        ManaAmountList.Add(Skill1ManaAmount); //0
        ManaAmountList.Add(Skill2ManaAmount); //1
        ManaAmountList.Add(Skill3ManaAmount); //2
        ManaAmountList.Add(Skill4ManaAmount); //...
        ManaAmountList.Add(Skill5ManaAmount);
        ManaAmountList.Add(Skill6ManaAmount);
        //Level
        LevelList.Add(Skill1);
        LevelList.Add(Skill2);
        LevelList.Add(Skill3);
        LevelList.Add(Skill4);
        LevelList.Add(Skill5);
        LevelList.Add(Skill6);
    }


    void Update()
    {
        if (!anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            canAttack = true;
        }
        else
        {
            canAttack = false;
        }
        if (anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            TurnThePlayer();
        }
        if (totalMana < 100f)
        {
            totalMana += Time.deltaTime * manaRegenSpeed;
            manaBar.fillAmount = totalMana / 100f;
        }
        CheckLevel();
        CheckMana();
        CheckToFade();
        CheckInput();
    }
    void CheckInput()
    {
        if (anim.GetInteger("Attack") == 0)
        {
            //playerOnClick.FinishedMovement = false;

            if (!anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                playerOnClick.FinishedMovement = true;
            }

        }

        //Skill Input
        if (Input.GetKeyDown(KeyCode.Alpha1) && totalMana >= Skill1ManaAmount && levelManager.GetLevel >= Skill1)
        {
            playerOnClick.TargetPosition = transform.position;
         
            if (playerOnClick.FinishedMovement || fadeImages[0] != 1 && canAttack)
            {
                totalMana -= Skill1ManaAmount;
                fadeImages[0] = 1;
                anim.SetInteger("Attack", 1);
               
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && totalMana >= Skill2ManaAmount && levelManager.GetLevel >= Skill2)
        {
            playerOnClick.TargetPosition = transform.position;
            if (playerOnClick.FinishedMovement || fadeImages[1] != 1 && canAttack)
            {
                totalMana -= Skill2ManaAmount;
                fadeImages[1] = 1;
                anim.SetInteger("Attack", 2);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && totalMana >= Skill3ManaAmount && levelManager.GetLevel >= Skill3)
        {
            playerOnClick.TargetPosition = transform.position;
            if (playerOnClick.FinishedMovement || fadeImages[2] != 1 && canAttack)
            {
                totalMana -= Skill3ManaAmount;
                fadeImages[2] = 1;
                anim.SetInteger("Attack", 3);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) && totalMana >= Skill4ManaAmount && levelManager.GetLevel >= Skill4)
        {
            playerOnClick.TargetPosition = transform.position;
            if (playerOnClick.FinishedMovement || fadeImages[3] != 1 && canAttack)
            {
                totalMana -= Skill4ManaAmount;
                fadeImages[3] = 1;
                anim.SetInteger("Attack", 4);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) && totalMana >= Skill5ManaAmount && levelManager.GetLevel >= Skill5)
        {
            playerOnClick.TargetPosition = transform.position;
            if (playerOnClick.FinishedMovement || fadeImages[4] != 1 && canAttack)
            {
                totalMana -= Skill5ManaAmount;
                fadeImages[4] = 1;
                anim.SetInteger("Attack", 5);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) && totalMana >= Skill6ManaAmount && levelManager.GetLevel >= Skill6)
        {
            playerOnClick.TargetPosition = transform.position;
            if (playerOnClick.FinishedMovement || fadeImages[5] != 1 && canAttack)
            {
                totalMana -= Skill6ManaAmount;
                fadeImages[5] = 1;
                anim.SetInteger("Attack", 6);
            }
        }
        else
        {
            anim.SetInteger("Attack", 0);
        }
    }
    void CheckToFade()
    {
        for (int i = 0; i < CooldownIcon.Length; i++)
        {
            if (fadeImages[i] == 1)
            {
                if (FadeAndWait(CooldownIcon[i], CooldownTimesList[i]))
                {
                    fadeImages[i] = 0;
                }
            }

        }
    }
    void CheckMana()
    {
        for (int i = 0; i < OutOfManaIcons.Length; i++)
        {
            if (levelManager.GetLevel >= LevelList[i])
            {
                if (totalMana < ManaAmountList[i])
                {
                    OutOfManaIcons[i].gameObject.SetActive(true);
                }
                else
                {
                    OutOfManaIcons[i].gameObject.SetActive(false);
                }
            }
        }
    }
    void CheckLevel()
    {
        for (int i = 0; i < OutOfManaIcons.Length; i++)
        {
            if (levelManager.GetLevel < LevelList[i])
            {
                OutOfManaIcons[i].gameObject.SetActive(true);
            }
        }
    }
    bool FadeAndWait(Image fadeImage, float fadeTime)
    {
        faded = false;
        if (fadeImage == null)
        {
            return faded;
        }
        if (!fadeImage.gameObject.activeInHierarchy)
        {
            fadeImage.gameObject.SetActive(true);
            fadeImage.fillAmount = 1f;
        }
        fadeImage.fillAmount -= fadeTime * Time.deltaTime;

        if (fadeImage.fillAmount <= 0f)
        {
            fadeImage.gameObject.SetActive(false);
            faded = true;
        }
        return faded;
    }
    void TurnThePlayer()
    {
        Vector3 targetPos = Vector3.zero;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            targetPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetPos - transform.position),
            playerOnClick.turnSpeed * Time.deltaTime);
    }
}
