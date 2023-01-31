using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerOnClick : MonoBehaviour
{
    //public float maxSpeed = 5f;
    //public float turnSpeed = 15f;
    //public float attackRange = 2f;

    //private Animator anim;
    //private CharacterController Controller;
    //private CollisionFlags collisionFlags= CollisionFlags.None;    //nerden temas olduðunu, nerden kuvvett uygulandýðýný belirten deðer döndürüyor
    //private Vector3 playerMove=Vector3.zero;
    //private Vector3 targetMovePoint = Vector3.zero;
    //private Vector3 targetAttackPoint= Vector3.zero;    //bunu ayýrmamýzdaki sebep, enemy'nin pozisyonunu her saniye güncellememiz gerek...Bu yüzden yeni vector oluþturuyoruz.

    //private float currentSpeed;
    //private float playerToPointDistance;
    //private float gravity = 9.8f;
    //private float height;

    //private bool canMove;
    //private bool canAttackMove;

    //private bool finishedMovement = true;
    //private Vector3 NewMovepoint;
    //private Vector3 NewAttackPoint;
    //private GameObject enemy;

    //public bool FinishedMovement
    //{
    //    get { return finishedMovement; }
    //    set { finishedMovement = value; }
    //}

    //public bool CanMove
    //{
    //    get { return canMove; }
    //    set { canMove=value;}
    //}
    //public Vector3 TargetPosition
    //{
    //    get { return targetMovePoint; }
    //    set { targetMovePoint = value; }
    //}

    //private void Awake()
    //{
    //    anim=GetComponent<Animator>();
    //    Controller=GetComponent<CharacterController>();
    //    currentSpeed = maxSpeed;
    //}



    //void Update()
    //{   
    //    CalculateHeight();
    //    CheckIfFinishedMovement();
    //    AttackMove();
    //}

    //bool IsGrounded()
    //{                         //eþit mi ? eþitse true deðilse false
    //    return collisionFlags == CollisionFlags.CollidedBelow ? true : false;   //yani alttan temas, yere deðmekte ise IsGrounded=true dön
    //}

    //void AttackMove()
    //{
    //    if (canAttackMove)
    //    {
    //        targetAttackPoint = enemy.gameObject.transform.position;
    //        NewAttackPoint = new Vector3(targetAttackPoint.x, transform.position.y, targetAttackPoint.z);
    //    }


    //    if (!anim.IsInTransition(0)&& anim.GetCurrentAnimatorStateInfo(0).IsName("Basic Attack"))   //o animasyon(slash) bitene kadar bu kod çalýþacak
    //    {
    //        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(NewAttackPoint - transform.position), turnSpeed *2* Time.deltaTime);    //karakterimizin yönünü bastýðýmýz yere doðru çevirmek için
    //    }

    //}

    //void CalculateHeight()  
    //{
    //    if (IsGrounded())   //yere deðiyorsa height=0 eðer deðmiyorsa da yerçekimi ivmesiyle yere çak
    //    {
    //        height = 0f;
    //    }
    //    else
    //    {
    //        height -= gravity * Time.deltaTime; //height=height-gravity*Time.deltaTime; 
    //    }
    //}

    //void CheckIfFinishedMovement()  //aksiyon yapmýyorsak,saldýrý yapmýyorsak MovePlayer'ý çaðýrmamýz gerekecek
    //{
    //    if (!finishedMovement)  //bir aksiyon yapýyoruz isek demek ???
    //    {                                                                                //burdaki sýfýr base layer oluyor
    //        if (!anim.IsInTransition(0)&&!anim.GetCurrentAnimatorStateInfo(0).IsName("Idle")&&anim.GetCurrentAnimatorStateInfo(0).normalizedTime>=0.8f )  //durmuyorsa, geçiþte de deðilse yani(skill basýlmýþsa mesela) diðer animator'e  geçmiþse ve animatorun/animasyonun oynatma süresi yüzde 80 geçtiðinde aþaðýdaki kodu çalýþtýr 
    //        {
    //            finishedMovement= true; //hareket bitti,animasyon bitti, yürümeye geçebiliriz...
    //        }

    //    }
    //    else    //finishedmovement=true.... her hangi bir aksiyonda deðilsek, vurmuyorsak savaþmýyorsak vs. harekete/yürümeye geçebiliriz. move player çalýþacak
    //    {
    //        MovePlayer();   //moveplayer sadece gidiceðimiz rotayý ayarlýyor ve karakterimizi durduruyor. hareket etmiyoruz o yöne doðru (moveplayerin sadece çalýþmasý yetmez)
    //        playerMove.y= height*Time.deltaTime;       //karakteri hareket ettirmek ve yerçekimini uygulamak için
    //        collisionFlags = Controller.Move(playerMove);   //playermove =öne/baktýðýn yöne doðru hareket etmemiz
    //    }

    //}


    //void MovePlayer()   //moveplayer sadece gidiceðimiz rotayý ayarlýyor ve karakterimizi durduruyor. hareket etmiyoruz o yöne doðru
    //{
    //    if (Input.GetMouseButtonDown(1))    //1 mouse'un sað tuþu 
    //    {
    //        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;
    //        if (Physics.Raycast(ray, out hit))
    //        {
    //            playerToPointDistance = Vector3.Distance(transform.position, hit.point);
    //            if (hit.collider.gameObject.layer==LayerMask.NameToLayer("Ground"))
    //            {
    //                if (playerToPointDistance>=1.0f)
    //                {
    //                    canMove = true;
    //                    canAttackMove = false;
    //                    targetMovePoint= hit.point; 
    //                }
    //            }
    //           else if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Target"))
    //            {
    //              enemy=hit.collider.gameObject.GetComponentInParent<EnemyHealth>().gameObject;
    //                canMove = true;
    //                canAttackMove = true;
    //            }
    //        }
    //    }
    //    if (canMove)
    //    {
    //        anim.SetFloat("Speed", 1.0f);   //burasý önemli...hareketi verdiðimiz yer, animator kýsmýndaki controller,blendtree falan vardý ya ordaki speed ifadesini 1 e eþitliyor, o da koþma animasyonunu çalýþtýrýyor
    //        if (!canAttackMove)
    //        {
    //            NewMovepoint = new Vector3(targetMovePoint.x, transform.position.y, targetMovePoint.z); //y'yi transform poisition almasýnýn sebebi, karakteri uçurmadýðýmýz için
    //            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(NewMovepoint - transform.position), turnSpeed * Time.deltaTime);    //karakterimizin yönünü bastýðýmýz yere doðru çevirmek için
    //        }
    //        else
    //        {
    //            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(NewAttackPoint - transform.position), turnSpeed * Time.deltaTime);    //karakterimizin yönünü bastýðýmýz yere doðru çevirmek için
    //        }

    //        playerMove = transform.forward * currentSpeed * Time.deltaTime; //hareketi burda veriyor, ileriye/baktýðý yöne doðru ilerletiriyor

    //        if (Vector3.Distance(transform.position,NewMovepoint)<=0.6f&&!canAttackMove)    //sonsuza dek koþmasýn diye, hitpoint'e varýnca dursun diye
    //        {
    //            canMove = false;
    //            canAttackMove = false;  // kod bug'a girmesin diye ayrýca böyle yapýyoruz
    //        }
    //        else if (canAttackMove)
    //        {
    //            if (Vector3.Distance(transform.position,NewAttackPoint)<=attackRange)   //range'e girdiysen...
    //            {
    //                playerMove.Set(0f, 0f, 0f);
    //                anim.SetFloat("Speed", 0f); //önce karakteri bir durduruyoruz, hareketi kesiyoruz tam,animasyonu kapatýyoruz.
    //                targetAttackPoint = Vector3.zero;   //bug olmasýn diye, targetattackpoint=newattackpoint ya her enemy yeri farklý, mesela 7 den 9a çýkarmak yerine 0dan 9a çýkarýyoruz x,y,z sini mesela...
    //                anim.SetTrigger("AttackMove");
    //                canAttackMove= false;   //bir daha týklamasýný istiyoruz yoksa false olmazsa sürekli aradaki bu mesafeyi kontrol edecek...
    //                canMove= false;     //false yapýyoruz çünkü yukardaki if statement'ýndan çýkamayacaðýz sonsuza dek yoksa...
    //            }

    //        }

    //    }
    //    else   //newmovepoint'e vardýðýnda canmove'u false yapmak için burayý yazýyoruz
    //    {
    //        playerMove.Set(0f, 0f, 0f);
    //        anim.SetFloat("Speed",0f);
    //    }

    //}



    public float maxSpeed = 5f;
    public float turnSpeed = 15f;
    public float attackRange = 2f;

    private Animator anim;
    private CharacterController Controller;
    private CollisionFlags collisonFlags = CollisionFlags.None;

    private Vector3 playerMove = Vector3.zero;
    private Vector3 targetMovePoint = Vector3.zero;
    private Vector3 targetAttackPoint = Vector3.zero;

    private float currentSpeed;
    private float playerToPointDistance;
    private float gravity = 9.8f;
    private float height;

    private bool canMove;
    private bool canAttackMove;
    private bool finishedMovement = true;
    private Vector3 NewMovepoint;
    private Vector3 NewAttackPoint;

    private GameObject enemy;
    public bool FinishedMovement
    {
        get
        {
            return finishedMovement;
        }
        set
        {
            finishedMovement = value;
        }
    }
    public bool CanMove
    {
        get
        {
            return canMove;
        }
        set
        {
            canMove = value;
        }
    }
    public Vector3 TargetPosition
    {
        get
        {
            return targetMovePoint;
        }
        set
        {
            targetMovePoint = value;
        }
    }


    private void Awake()
    {
        anim = GetComponent<Animator>();
        Controller = GetComponent<CharacterController>();
        currentSpeed = maxSpeed;
    }

    void Update()
    {
        CalculateHeight();
        CheckIfFinishedMovement();
        AttackMove();
    }
    bool IsGrounded()
    {
        return collisonFlags == CollisionFlags.CollidedBelow ? true : false;
    }
    void AttackMove()
    {
        if (canAttackMove)
        {
            targetAttackPoint = enemy.gameObject.transform.position;

            NewAttackPoint = new Vector3(targetAttackPoint.x, transform.position.y, targetAttackPoint.z);
        }
        if (!anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo(0).IsName("Basic Attack"))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(NewAttackPoint - transform.position), turnSpeed * 2 * Time.deltaTime); ;
        }
    }
    void CalculateHeight()
    {
        if (IsGrounded())
        {
            height = 0f;
        }
        else
        {
            height -= gravity * Time.deltaTime;
        }
    }
    void CheckIfFinishedMovement()
    {
        if (!finishedMovement)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle")|| !anim.IsInTransition(0) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Idle") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.8f)
            {
                finishedMovement = true;
            }
        }
        else
        {
            MovePlayer();
            playerMove.y = height * Time.deltaTime;
            collisonFlags = Controller.Move(playerMove);
        }
    }
    void MovePlayer()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                playerToPointDistance = Vector3.Distance(transform.position, hit.point);
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
                {
                    if (playerToPointDistance >= 1.0f)
                    {
                        canMove = true;
                        canAttackMove = false;
                        targetMovePoint = hit.point;
                    }
                }
                else if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Target"))
                {
                    enemy = hit.collider.gameObject.GetComponentInParent<EnemyHealth>().gameObject;
                    canMove = true;
                    canAttackMove = true;
                }
            }
        }
        if (canMove)
        {
            anim.SetFloat("Speed", 1.0f);

            if (!canAttackMove)
            {
                NewMovepoint = new Vector3(targetMovePoint.x, transform.position.y, targetMovePoint.z);

                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(NewMovepoint - transform.position), turnSpeed * Time.deltaTime);
            }
            else
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(NewAttackPoint - transform.position), turnSpeed * Time.deltaTime);
            }

            playerMove = transform.forward * currentSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, NewMovepoint) <= 0.6f && !canAttackMove)
            {
                canMove = false;
                canAttackMove = false;
            }
            else if (canAttackMove)
            {
                if (Vector3.Distance(transform.position, NewAttackPoint) <= attackRange)
                {
                    playerMove.Set(0f, 0f, 0f);
                    anim.SetFloat("Speed", 0f);
                    targetAttackPoint = Vector3.zero;
                    anim.SetTrigger("AttackMove");
                    canAttackMove = false;
                    canMove = false;
                }
            }
        }
        else
        {
            playerMove.Set(0f, 0f, 0f);
            anim.SetFloat("Speed", 0f);
        }

    }

}
