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

        if (Input.GetMouseButtonUp(1))  //mouse'un sað týkýný kaldýrdýðým anda gerçekleþecek olan 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //kameradan mouseun olduðu yere bir ýþýn oluþturuyoruz.
            RaycastHit hit;      //ýþýndan bilgi almamýz lazým,bize geri dönüþ vermesi lazým (hit adýnda)

            if (Physics.Raycast(ray, out hit))  //Raycast ile ýþýný gönder dedim, ray= ýþýnýmýz, bize dönüþü de hit olarak yap diyoruz
            {
                if (hit.collider.gameObject.layer==LayerMask.NameToLayer("Ground"))
                {
                    Vector3 LastPos = hit.point;
                    LastPos.y = 0.35f;      //ne olursa olsun týkladýðým yerin Y'si 0.35 olacak, oluþacak sembol orda oluþacak

                    Instantiate(mousePoint,LastPos,Quaternion.identity);  //instantiate verdiðimiz herhangi bir prefab'i o an verdiðimiz konuma doðru ýþýnlýyor bir anda, yoktan var eden bir komut.
                                       //eðer bu deðerleri girmezsek default olarak 000 konumunda ve rotasyonunda bir ýþýnlanma saðlar.
                                        //quaternian identity diyince de yani kendi rotasyonunda bize gelsin diyoruz...
                }
            }



        }
    }
    private void CursorChanger()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //kameradan mouseun olduðu yere bir ýþýn oluþturuyoruz.
        RaycastHit hit;      //ýþýndan bilgi almamýz lazým,bize geri dönüþ vermesi lazým (hit adýnda)

        if (Physics.Raycast(ray, out hit))  //Raycast ile ýþýný gönder dedim, ray= ýþýnýmýz, bize dönüþü de hit olarak yap diyoruz
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
