using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour     //bunu, bu scripti direkt olarak HealthUI canvas�n�n i�ine girip AddComponent diyoruz...
{
  
    void Update()
    {
        this.transform.LookAt(Camera.main.transform);       
    }

}
