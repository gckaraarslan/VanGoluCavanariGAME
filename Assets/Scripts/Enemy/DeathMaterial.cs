using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMaterial : MonoBehaviour
{
    [SerializeField] private Material Dissolve;
    void Start()
    {
        GetComponent<Renderer>().material = Dissolve;   //Skeleton_mesh i�indeki Skinned Mesh Renderer i�indeki Materials i�indeki Element 0 = skeleton_MAT material'ini Dissolve'a e�itliyoruz.
        GetComponent<SpawnEffect>().enabled = true; //bu script ne zaman Material Dissolve'a d�nerse o zaman �al��acakt�r...    
    }

  


}
