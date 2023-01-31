using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRawImage : MonoBehaviour
{
    //buras� UV Rect in y si i�in yani orbun i�inde hareketlilik olu�turmak i�in, g�rsel efekt cart curt i�te :D

    public float horizontalSpeed;
    public float verticalSpeed;

    RawImage myRawImage;
    
    void Start()
    {
        myRawImage= GetComponent<RawImage>();
    }

   
    void Update()
    {
        Rect currentUv = myRawImage.uvRect; //UV Rect z�mb�rt�s� i�te 

        currentUv.x -=Time.deltaTime* horizontalSpeed;
        currentUv.y-=Time.deltaTime* verticalSpeed;

        if (currentUv.x<=-1f||currentUv.x>=1f)
        {
            currentUv.x = 0f;
        }
        if (currentUv.y<=-1f||currentUv.y>=1f)
        {
            currentUv.y = 0f;
        }
        myRawImage.uvRect = currentUv;
    }
}
