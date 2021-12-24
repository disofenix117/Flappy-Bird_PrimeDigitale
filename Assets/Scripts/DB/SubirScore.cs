using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SubirScore : MonoBehaviour
{
 string inserarDatos="https://prime-pruebasweb.com/rankingFlappy/insertar.php";
  //string inserarDatos="http://localhost/paginaweb/Prime%20Digital%20Pruebas/Juego%20Flappy/Scores/insertar.php";
  
  
    public int score;
    public int cartas;
    public string tiempo;
    public InputField nombre;

    public void Enviar()
{
    StartCoroutine("subirscore");
    SceneManager.LoadScene("TotalScore");
     

}

   IEnumerator subirscore()
   {
        
        score=GetComponent<UserScore>().userScore;
        cartas=GetComponent<UserScore>().userCartas;
        tiempo=GetComponent<UserScore>().Time;
        
        WWWForm form = new WWWForm();
        form.AddField("nombre",PlayerPrefs.GetString("user"));
        form.AddField("score", score);
        form.AddField("tiempo", tiempo);
        form.AddField("cartas", cartas);
    
       WWW subir =new WWW(inserarDatos,form);
       yield return subir;
      yield return new WaitForSeconds(2);
       Debug.Log(subir.text);   
       
       
   }
}
