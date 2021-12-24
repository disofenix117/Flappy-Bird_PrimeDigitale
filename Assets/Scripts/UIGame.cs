using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIGame : MonoBehaviour
{

    UserScore user;
    Player player;
    timer Timer;
    public Text Score;
    public Text Tiempo;
     public GameObject Panellost;
     public GameObject PanelPausa;
     public GameObject Begin;
     public List<Image> Cartas;


    // Start is called before the first frame update
    void Start()
    {
        user=GetComponent<UserScore>();
        Timer=GetComponent<timer>();
        Panellost.SetActive(false);
        PanelPausa.SetActive(false);
        Begin.SetActive(false);
        user.userScore=0;
        Time.timeScale=1;
        //StartCoroutine(inicio())        ;
        Pausa();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text=user.userScore.ToString(); 
        if(Timer.s<10)
        {
            Tiempo.text=Timer.m.ToString()+":0"+Timer.s.ToString();  
        }
        else
        {
            Tiempo.text=Timer.m.ToString()+":"+Timer.s.ToString();  
        }
        
        

        
    }
    public void GameOver()
    {
        Panellost.SetActive(true);
        Time.timeScale=0;
         user.Time=Timer.m.ToString()+":"+Timer.s.ToString();
    }
    public void Pausa()
    {
        Time.timeScale=0;
        Timer.stopTimer();
        PanelPausa.SetActive(true);
        

    }
      public void Reanudar()
    {
        PanelPausa.SetActive(false);
        Timer.updateTimer();
        Time.timeScale=1;
    }


    IEnumerator inicio()
    {
         Begin.SetActive(true);
         Time.timeScale=0;
        yield return new WaitForSeconds(2);
        Begin.SetActive(false);
        Time.timeScale=1;
        Timer.startTimer();
        player.Play=true;
        

    }
}
