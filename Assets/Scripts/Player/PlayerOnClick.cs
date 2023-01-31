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
    //private CollisionFlags collisionFlags= CollisionFlags.None;    //nerden temas oldu�unu, nerden kuvvett uyguland���n� belirten de�er d�nd�r�yor
    //private Vector3 playerMove=Vector3.zero;
    //private Vector3 targetMovePoint = Vector3.zero;
    //private Vector3 targetAttackPoint= Vector3.zero;    //bunu ay�rmam�zdaki sebep, enemy'nin pozisyonunu her saniye g�ncellememiz gerek...Bu y�zden yeni vector olu�turuyoruz.

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
    //{                         //e�it mi ? e�itse true de�ilse false
    //    return collisionFlags == CollisionFlags.CollidedBelow ? true : false;   //yani alttan temas, yere de�mekte ise IsGrounded=true d�n
    //}

    //void AttackMove()
    //{
    //    if (canAttackMove)
    //    {
    //        targetAttackPoint = enemy.gameObject.transform.position;
    //        NewAttackPoint = new Vector3(targetAttackPoint.x, transform.position.y, targetAttackPoint.z);
    //    }


    //    if (!anim.IsInTransition(0)&& anim.GetCurrentAnimatorStateInfo(0).IsName("Basic Attack"))   //o animasyon(slash) bitene kadar bu kod �al��acak
    //    {
    //        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(NewAttackPoint - transform.position), turnSpeed *2* Time.deltaTime);    //karakterimizin y�n�n� bast���m�z yere do�ru �evirmek i�in
    //    }

    //}

    //void CalculateHeight()  
    //{
    //    if (IsGrounded())   //yere de�iyorsa height=0 e�er de�miyorsa da yer�ekimi ivmesiyle yere �ak
    //    {
    //        height = 0f;
    //    }
    //    else
    //    {
    //        height -= gravity * Time.deltaTime; //height=height-gravity*Time.deltaTime; 
    //    }
    //}

    //void CheckIfFinishedMovement()  //aksiyon yapm�yorsak,sald�r� yapm�yorsak MovePlayer'� �a��rmam�z gerekecek
    //{
    //    if (!finishedMovement)  //bir aksiyon yap�yoruz isek demek ???
    //    {                                                                                //burdaki s�f�r base layer oluyor
    //        if (!anim.IsInTransition(0)&&!anim.GetCurrentAnimatorStateInfo(0).IsName("Idle")&&anim.GetCurrentAnimatorStateInfo(0).normalizedTime>=0.8f )  //durmuyorsa, ge�i�te de de�ilse yani(skill bas�lm��sa mesela) di�er animator'e  ge�mi�se ve animatorun/animasyonun oynatma s�resi y�zde 80 ge�ti�inde a�a��daki kodu �al��t�r 
    //        {
    //            finishedMovement= true; //hareket bitti,animasyon bitti, y�r�meye ge�ebiliriz...
    //        }

    //    }
    //    else    //finishedmovement=true.... her hangi bir aksiyonda de�ilsek, vurmuyorsak sava�m�yorsak vs. harekete/y�r�meye ge�ebiliriz. move player �al��acak
    //    {
    //        MovePlayer();   //moveplayer sadece gidice�imiz rotay� ayarl�yor ve karakterimizi durduruyor. hareket etmiyoruz o y�ne do�ru (moveplayerin sadece �al��mas� yetmez)
    //        playerMove.y= height*Time.deltaTime;       //karakteri hareket ettirmek ve yer�ekimini uygulamak i�in
    //        collisionFlags = Controller.Move(playerMove);   //playermove =�ne/bakt���n y�ne do�ru hareket etmemiz
    //    }

    //}


    //void MovePlayer()   //moveplayer sadece gidice�imiz rotay� ayarl�yor ve karakterimizi durduruyor. hareket etmiyoruz o y�ne do�ru
    //{
    //    if (Input.GetMouseButtonDown(1))    //1 mouse'un sa� tu�u 
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
    //        anim.SetFloat("Speed", 1.0f);   //buras� �nemli...hareketi verdi�imiz yer, animator k�sm�ndaki controller,blendtree falan vard� ya ordaki speed ifadesini 1 e e�itliyor, o da ko�ma animasyonunu �al��t�r�yor
    //        if (!canAttackMove)
    //        {
    //            NewMovepoint = new Vector3(targetMovePoint.x, transform.position.y, targetMovePoint.z); //y'yi transform poisition almas�n�n sebebi, karakteri u�urmad���m�z i�in
    //            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(NewMovepoint - transform.position), turnSpeed * Time.deltaTime);    //karakterimizin y�n�n� bast���m�z yere do�ru �evirmek i�in
    //        }
    //        else
    //        {
    //            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(NewAttackPoint - transform.position), turnSpeed * Time.deltaTime);    //karakterimizin y�n�n� bast���m�z yere do�ru �evirmek i�in
    //        }

    //        playerMove = transform.forward * currentSpeed * Time.deltaTime; //hareketi burda veriyor, ileriye/bakt��� y�ne do�ru ilerletiriyor

    //        if (Vector3.Distance(transform.position,NewMovepoint)<=0.6f&&!canAttackMove)    //sonsuza dek ko�mas�n diye, hitpoint'e var�nca dursun diye
    //        {
    //            canMove = false;
    //            canAttackMove = false;  // kod bug'a girmesin diye ayr�ca b�yle yap�yoruz
    //        }
    //        else if (canAttackMove)
    //        {
    //            if (Vector3.Distance(transform.position,NewAttackPoint)<=attackRange)   //range'e girdiysen...
    //            {
    //                playerMove.Set(0f, 0f, 0f);
    //                anim.SetFloat("Speed", 0f); //�nce karakteri bir durduruyoruz, hareketi kesiyoruz tam,animasyonu kapat�yoruz.
    //                targetAttackPoint = Vector3.zero;   //bug olmas�n diye, targetattackpoint=newattackpoint ya her enemy yeri farkl�, mesela 7 den 9a ��karmak yerine 0dan 9a ��kar�yoruz x,y,z sini mesela...
    //                anim.SetTrigger("AttackMove");
    //                canAttackMove= false;   //bir daha t�klamas�n� istiyoruz yoksa false olmazsa s�rekli aradaki bu mesafeyi kontrol edecek...
    //                canMove= false;     //false yap�yoruz ��nk� yukardaki if statement'�ndan ��kamayaca��z sonsuza dek yoksa...
    //            }

    //        }

    //    }
    //    else   //newmovepoint'e vard���nda canmove'u false yapmak i�in buray� yaz�yoruz
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
