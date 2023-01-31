using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    public Texture2D cursorTextureNormal;
    public Texture2D cursorTextureEnemy;


    private CursorMode mode = CursorMode.ForceSoftware;
    private Vector2 hotSpot = Vector2.zero;

    public GameObject mousePoint;



    // Update is called once per frame
    void Update()
    {
        CursorChanger();

        if (Input.GetMouseButtonUp(1))  //mouse'un sa� t�k�n� kald�rd���m anda ger�ekle�ecek olan 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //kameradan mouseun oldu�u yere bir ���n olu�turuyoruz.
            RaycastHit hit;      //���ndan bilgi almam�z laz�m,bize geri d�n�� vermesi laz�m (hit ad�nda)

            if (Physics.Raycast(ray, out hit))  //Raycast ile ���n� g�nder dedim, ray= ���n�m�z, bize d�n��� de hit olarak yap diyoruz
            {
                if (hit.collider.gameObject.layer==LayerMask.NameToLayer("Ground"))
                {
                    Vector3 LastPos = hit.point;
                    LastPos.y = 0.35f;      //ne olursa olsun t�klad���m yerin Y'si 0.35 olacak, olu�acak sembol orda olu�acak

                    Instantiate(mousePoint,LastPos,Quaternion.identity);  //instantiate verdi�imiz herhangi bir prefab'i o an verdi�imiz konuma do�ru ���nl�yor bir anda, yoktan var eden bir komut.
                                       //e�er bu de�erleri girmezsek default olarak 000 konumunda ve rotasyonunda bir ���nlanma sa�lar.
                                        //quaternian identity diyince de yani kendi rotasyonunda bize gelsin diyoruz...
                }
            }



        }
    }
    private void CursorChanger()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //kameradan mouseun oldu�u yere bir ���n olu�turuyoruz.
        RaycastHit hit;      //���ndan bilgi almam�z laz�m,bize geri d�n�� vermesi laz�m (hit ad�nda)

        if (Physics.Raycast(ray, out hit))  //Raycast ile ���n� g�nder dedim, ray= ���n�m�z, bize d�n��� de hit olarak yap diyoruz
        {
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Target"))
            {
                Cursor.SetCursor(cursorTextureEnemy, hotSpot, mode);
            }
            else
            {
                Cursor.SetCursor(cursorTextureNormal, hotSpot, mode);
            }
        }
    }
}
