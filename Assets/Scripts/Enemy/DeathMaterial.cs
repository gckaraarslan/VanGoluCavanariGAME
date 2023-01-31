using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMaterial : MonoBehaviour
{
    [SerializeField] private Material Dissolve;
    void Start()
    {
        GetComponent<Renderer>().material = Dissolve;   //Skeleton_mesh içindeki Skinned Mesh Renderer içindeki Materials içindeki Element 0 = skeleton_MAT material'ini Dissolve'a eþitliyoruz.
        GetComponent<SpawnEffect>().enabled = true; //bu script ne zaman Material Dissolve'a dönerse o zaman çalýþacaktýr...    
    }

  


}
