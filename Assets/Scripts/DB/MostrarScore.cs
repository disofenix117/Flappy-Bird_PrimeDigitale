using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarScore : MonoBehaviour
{



    string MostrarNombre="https://prime-pruebasweb.com/rankingFlappy/MostrarNombre.php";
  string mostrarScore="https://prime-pruebasweb.com/rankingFlappy/MostrarScore.php";
   string MostrarTiempo="https://prime-pruebasweb.com/rankingFlappy/MostrarTiempo.php";
    string MostrarCartas="https://prime-pruebasweb.com/rankingFlappy/MostrarCartas.php";
   /*
    string MostrarNombre="http://localhost/paginaweb/Prime%20Digital%20Pruebas/Juego%20Flappy/Scores/MostrarNombre.php";
   string mostrarScore="http://localhost/paginaweb/Prime%20Digital%20Pruebas/Juego%20Flappy/Scores/MostrarScore.php";
   string MostrarTiempo="http://localhost/paginaweb/Prime%20Digital%20Pruebas/Juego%20Flappy/Scores/MostrarTiempo.php";
   string MostrarCartas="http://localhost/paginaweb/Prime%20Digital%20Pruebas/Juego%20Flappy/Scores/MostrarCartas.php"; 
   */
     void Awake()
    {
        Ranking();
        
    }

public void Ranking()
{
    StartCoroutine("mostrar");
}
     IEnumerator mostrar()
   {
       Text tabla=GameObject.FindGameObjectWithTag("Tabla").GetComponent<Text>();
       Text tabla1=GameObject.FindGameObjectWithTag("Tabla1").GetComponent<Text>();
       Text tabla2=GameObject.FindGameObjectWithTag("Tabla2").GetComponent<Text>();
       Text tabla3=GameObject.FindGameObjectWithTag("Tabla3").GetComponent<Text>();
       WWW recibirN =new WWW(MostrarNombre);
       WWW recibirS =new WWW(mostrarScore);
       WWW recibirT =new WWW(MostrarTiempo);
       WWW recibirC =new WWW(MostrarCartas);
       yield return recibirN;
       yield return recibirS;
       yield return recibirT;
       yield return recibirC;
       tabla.text=recibirN.text;
       tabla1.text=recibirS.text;
       tabla2.text=recibirT.text;
       tabla3.text=recibirC.text;
       yield return new WaitForSeconds(2);



   }
}
