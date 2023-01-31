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
    //// public float[] coolDownTime; diyip dizili þekilde de yapýlabilir ama ben þimdilik amelemasyon yapýcam....
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

    //[Header("Required Level")]  //for döngüsüne alabilmek için bunlarý listeye alýcaz aþaðýda
    //public int Skill1 = 2;
    //public int Skill2 = 3;
    //public int Skill3 = 4;
    //public int Skill4 = 5;
    //public int Skill5 = 6;
    //public int Skill6 = 7;






    //private bool canAttack = true;
    //private bool faded=false;   //bunu yazma nedenimiz; solduðu zaman,iconumuz tekrardan siyah olduðu zaman faded=true olacak,  (fillamount=1)
    //                            //bu true olunca fillamoount 1'den 0'a doðru gidecek, filamount=0 olunca faded=false olacak ve fillamount tekrardan 1 olacak

    //private int[] fadeImages = new int[] {0,0,0,0,0,0 }; //Imageleri int arrayliste alýyoruz... (fade =false yani fillamount=0)

    //[HideInInspector]public List<float> CoolDownTimesList= new List<float>(); 
    //private List<float> ManaAmountList=new List<float>();

    //private List<int> LevelList = new List<int>();



    //private Animator anim; //referans olarak animatörü çekiyorum
    //private PlayerOnClick playerOnClick;

    //private LevelManager levelManager;

    //private void Awake()
    //{
    //    anim= GetComponent<Animator>();
    //    playerOnClick= GetComponent<PlayerOnClick>();
    //    manaBar = GameObject.Find("ManaOrb").GetComponent<Image>(); //burda yaptýðýmýz iþlem; manaorb objesini bul ve bana Image Componentini getir ve manaBar yap
    //    //player içindeki mana bar'ýn oraya sürükleyebilirdik de...
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
    //    if (!anim.IsInTransition(0)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))    //geçiþte deðilsek ve IDLE(durma veya yürümedeysek,idle'ýn içinde ikisi de var bunda)
    //    {

    //        canAttack = true; 
    //    }
    //    else
    //    {
    //        canAttack= false;
    //    }

    //    if (anim.IsInTransition(0)&&anim.GetCurrentAnimatorStateInfo(0).IsName("Idle")) //Idle'dan geçiþ anýna geçtiði o anda aþaðýyý çalýþtýr
    //    {
    //        TurnThePlayer();
    //    }

    //    if (totalMana<100f)
    //    {
    //        totalMana += Time.deltaTime * manaRegenSpeed;
    //        manaBar.fillAmount = totalMana / 100f;  //fillamount maximum 1 e eþit olabildiði için
    //    }

    //    CheckLevel();
    //    CheckMana();
    //    CheckToFade();
    //    CheckInput();
    //}


    //private void CheckInput()   //animatörleri dizerken ordaki exit time cart curt o kýsýmlardaki deðerlere bir daha bak videoda........................................................................
    //{
    //    if (anim.GetInteger("Attack") == 0)   //Animator içinde(controller içinde) Attack Parametresinin deðerini getir, eðer sýfýra eþitse...
    //    {                                   //yani hiçbir þey yapmadýðýmýz senaryo

    //      // playerOnClick.FinishedMovement = false; //aksiyon bitmiþ mi hayýr...bu durumda da diðer skilleri basamýyoruz...
    //        if (!anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))       //eðer IDLE'daysak ve geçiþte deðilsek, yani saldýrýyý bitirdiysek;finishedmovement=true yap
    //        {
    //            playerOnClick.FinishedMovement = true; //aksiyon bitti
    //        }   //bir tuþa basýnca skill bitene kadar hareket edemiyoruz. bunun altyapýsýný yaptýk
    //    }
    //    //skill INPUT
    //    if (Input.GetKeyDown(KeyCode.Alpha1)&& totalMana >= Skill1ManaAmount && levelManager.GetLevel>=Skill1)
    //    {
    //        playerOnClick.TargetPosition=transform.position;    //target position'ý bulunduðun nokta yapýyoruz ki hareketini durdurmak için
    //        if (playerOnClick.FinishedMovement && fadeImages[0]!=1&&canAttack)
    //        {
    //            totalMana = totalMana - Skill1ManaAmount;
    //            fadeImages[0] = 1;  //bu skili bugda gibi sürekli basabilmemizi engellemek için yoksa üstteki koþul geçerli olur ve sürekli taktaktak basarýz, bu da olmaz....
    //            anim.SetInteger("Attack", 1);   //playercontrollerdaki Attack parametresinin deðerini 1'e eþitle
    //        }
    //    }
    //   else if (Input.GetKeyDown(KeyCode.Alpha2) && totalMana >= Skill2ManaAmount&&levelManager.GetLevel >= Skill2)
    //    {
    //        playerOnClick.TargetPosition = transform.position;    //target position'ý bulunduðun nokta yapýyoruz ki hareketini durdurmak için
    //        if (playerOnClick.FinishedMovement && fadeImages[1] != 1 && canAttack)
    //        {
    //            totalMana = totalMana - Skill2ManaAmount;
    //            fadeImages[1] = 1;  //bu skili bugda gibi sürekli basabilmemizi engellemek için yoksa üstteki koþul geçerli olur ve sürekli taktaktak basarýz, bu da olmaz....
    //            anim.SetInteger("Attack", 2);   //playercontrollerdaki Attack parametresinin deðerini 2'e eþitle
    //        }
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Alpha3) && totalMana >= Skill3ManaAmount && levelManager.GetLevel >= Skill3)
    //    {
    //        playerOnClick.TargetPosition = transform.position;    //target position'ý bulunduðun nokta yapýyoruz ki hareketini durdurmak için
    //        if (playerOnClick.FinishedMovement && fadeImages[2] != 1 && canAttack)
    //        {
    //            totalMana = totalMana - Skill3ManaAmount;
    //            fadeImages[2] = 1;  //bu skili bugda gibi sürekli basabilmemizi engellemek için yoksa üstteki koþul geçerli olur ve sürekli taktaktak basarýz, bu da olmaz....
    //            anim.SetInteger("Attack", 3);   //playercontrollerdaki Attack parametresinin deðerini 3'e eþitle
    //        }
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Alpha4) && totalMana >= Skill4ManaAmount && levelManager.GetLevel >= Skill4)
    //    {
    //        playerOnClick.TargetPosition = transform.position;    //target position'ý bulunduðun nokta yapýyoruz ki hareketini durdurmak için
    //        if (playerOnClick.FinishedMovement && fadeImages[3] != 1 && canAttack)
    //        {
    //            totalMana = totalMana - Skill4ManaAmount;
    //            fadeImages[3] = 1;  //bu skili bugda gibi sürekli basabilmemizi engellemek için yoksa üstteki koþul geçerli olur ve sürekli taktaktak basarýz, bu da olmaz....
    //            anim.SetInteger("Attack", 4);   //playercontrollerdaki Attack parametresinin deðerini 4'e eþitle
    //        }
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Alpha5) && totalMana >= Skill5ManaAmount && levelManager.GetLevel >= Skill5)
    //    {
    //        playerOnClick.TargetPosition = transform.position;    //target position'ý bulunduðun nokta yapýyoruz ki hareketini durdurmak için
    //        if (playerOnClick.FinishedMovement && fadeImages[4] != 1 && canAttack)
    //        {
    //            totalMana = totalMana - Skill5ManaAmount;
    //            fadeImages[4] = 1;  //bu skili bugda gibi sürekli basabilmemizi engellemek için yoksa üstteki koþul geçerli olur ve sürekli taktaktak basarýz, bu da olmaz....
    //            anim.SetInteger("Attack", 5);   //playercontrollerdaki Attack parametresinin deðerini 5'e eþitle
    //        }
    //    }
    //    else if (Input.GetKeyDown(KeyCode.Alpha6) && totalMana >= Skill6ManaAmount)
    //    {
    //        playerOnClick.TargetPosition = transform.position;    //target position'ý bulunduðun nokta yapýyoruz ki hareketini durdurmak için
    //        if (playerOnClick.FinishedMovement && fadeImages[5] != 1 && canAttack && levelManager.GetLevel >= Skill6)
    //        {   totalMana=totalMana- Skill6ManaAmount;
    //            fadeImages[5] = 1;  //bu skili bugda gibi sürekli basabilmemizi engellemek için yoksa üstteki koþul geçerli olur ve sürekli taktaktak basarýz, bu da olmaz....
    //            anim.SetInteger("Attack", 6);   //playercontrollerdaki Attack parametresinin deðerini 6'e eþitle
    //        }
    //    }
    //    else
    //    {
    //        anim.SetInteger("Attack", 0);   // o da bizi en baþa göndercek, orda eðer
    //    }

    //}





    //void CheckToFade()  //fadeImage'i ve fadeTime'ý doldurabilmek için bu metodun içinde FadeAndWait'i çaðýrýyoruz
    //{
    //    for (int i = 0; i < CooldownIcon.Length; i++)
    //    {
    //        if (fadeImages[i] == 1)   //alpha1'e bastýðýmýzda fadeimages o indexi 1 e eþit olacak ve
    //        {
    //            if (FadeAndWait(CooldownIcon[i], CoolDownTimesList[i])) // Hangi resmi hangi sürede kýsacaðýný veriyoruz burda
    //            {
    //                fadeImages[i] = 0;                          //ve sonra bu fadeImage'in o indeksi 0'a eþitle tekrardan
    //            }
    //        }
    //    }

    //}    

    //void CheckMana()
    //{
    //    for (int i = 0; i < OutOfManaIcons.Length; i++)
    //    {
    //        if (levelManager.GetLevel >= LevelList[i])  //eðer skill için gerekli levelde deðilsem hiç mana yetiyor mu yetmiyor mu kontrol dahi etme...
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
    //            OutOfManaIcons[i].gameObject.SetActive(true);   //böylelikle skil kararacak... (fillamount=1 olunca kararýyor ya onun gibi fill olmuþ gibi) karartma image'ý aktif hale geliyor yani
    //        }

    //    }
    //}

    //            //BURADA BÝR TERSLÝK VAR GÝBÝ, ÝYÝCE OTURTMAM LAZIM                     
    //bool FadeAndWait(Image fadeImage,float fadeTime)  //solduysa true, solmadýysa false almamýz lazým bundan...Bu metodu bir yerden çaðýrdýðýmýzda bizden bir image istiyecek
    //{                                   //bu sayede her skill attýðýmýzda o skilin IMAGE'ini çekeceðiz, onu siyaha çevirip çevirmediðini anlayacaðýz
    //    faded = false;               //yani fillamount=0, skille basýnca fillamount=1 olacak yani faded=trueya dönecek
    //    if (fadeImage == null)           //1-2-3 e falan basýnca bir image gelmezse oyun çökmesin diye...
    //    {
    //        return faded;
    //    }

    //    if (!fadeImage.gameObject.activeInHierarchy)    //Image'ün solüst köþesi tikli deðilse eðer...
    //    {
    //        fadeImage.gameObject.SetActive(true);       //orayý tikle demiþ oluyoruz bir nevi...
    //        fadeImage.fillAmount = 1f;                  //bunla beraber fillamount=1 olmalý ki cd'ye girmiþ olsun. 
    //    }

    //    fadeImage.fillAmount -= fadeTime * Time.deltaTime;

    //    if (fadeImage.fillAmount<=0f)   //sýfýra ulaþtýðýnda bunu(Image) kapatýyor faded'ý true yapýyoruz.
    //    {
    //        fadeImage.gameObject.SetActive(false);  //Image'ün üstköþesindeki tiki kaldýrdýðýný düþün, yani fade özelliði iptal yani fillamount=0 gibi...
    //        faded = true;   //bunun false olmasý gerek miyor mu ?????? çünkü fill amount sýfýra eþitlendi...
    //    }
    //    return faded;   //burda true geldiðinde mesela, fadeandwait true gelmiþ oluyor ya o da üsttechecktofade'de fadeimages[i]=0 yapýyor, o sayede de skill kullanýlabilir hale geliyor tekrar
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
