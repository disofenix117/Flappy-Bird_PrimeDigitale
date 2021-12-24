using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumaPuntos : MonoBehaviour
{

     int aux=110;
  
        void OnTriggerEnter2D(Collider2D Coll)
    {
        UserScore user= FindObjectOfType<UserScore>();
         Generador gen=FindObjectOfType<Generador>();
        user.userScore=user.userScore+10;
        int puntos=user.userScore;
       

          if((user.userScore%aux)==0)
        {
            aux=aux*2;
           gen.Nivel();
        }


    }
}
