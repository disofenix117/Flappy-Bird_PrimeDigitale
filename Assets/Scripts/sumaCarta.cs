using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class sumaCarta : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D Coll)
    {
         Generador gen=FindObjectOfType<Generador>();
         UserScore user= FindObjectOfType<UserScore>();
         UIGame ui=FindObjectOfType<UIGame>();
       //Debug.Log("cogido");
       Destroy(gameObject);
       if(gen.Cartas.Count!=0)
       {
            int aux=gen.tamCartas;
            string nombreCarta=gen.Cartas[aux].name;
            switch (nombreCarta)
            {
                case "Carta1":
                {
                    ui.Cartas[0].sprite=gen.Cartas[aux];
                    break;
                }
                case "Carta2":
                {
                    ui.Cartas[1].sprite=gen.Cartas[aux];
                    break;
                }
                case "Carta3":
                {
                    ui.Cartas[2].sprite=gen.Cartas[aux];
                    break;
                }
                case "Carta4":
                {
                    ui.Cartas[3].sprite=gen.Cartas[aux];
                    break;
                }
                case "Carta5":
                {
                    ui.Cartas[4].sprite=gen.Cartas[aux];
                    break;
                }
            }
           user.userCartas++;
            gen.Cartas.RemoveAt(aux);
            aux=Random.Range(0,gen.Cartas.Count);
            gen.tamCartas=aux;
       }
    }
}
