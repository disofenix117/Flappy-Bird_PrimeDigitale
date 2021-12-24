using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class Usuario : MonoBehaviour
{
   public InputField nombre;
     string MostrarUser="https://prime-pruebasweb.com/rankingFlappy/iniciar.php";
   //string MostrarUser="http://localhost/paginaweb/Prime%20Digital%20Pruebas/Juego%20Flappy/Scores/iniciar.php";

public void User()
{
    StartCoroutine("mostrar");
}
     IEnumerator mostrar()
   {
      // Text tabla=GameObject.FindGameObjectWithTag("usuario").GetComponent<Text>();

        WWWForm form = new WWWForm();
        form.AddField("nombre", nombre.text);

      // WWW recibirN =new WWW(MostrarUser,form);
       PlayerPrefs.SetString("user",nombre.text);

       UnityWebRequest send=UnityWebRequest.Post(MostrarUser,form);
       yield return send.SendWebRequest();
      



   }
}
