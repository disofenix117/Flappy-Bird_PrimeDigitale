using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Generador : MonoBehaviour
{
    float tiempoMax;
    float tiempoIn;
    public GameObject obst;
    public GameObject Carta;
    UserScore user;
    public float altura;
    int aux;
    public int tamCartas;
    int tamObstaculos;
     
    public List<Sprite> Cartas;
 
    
  
    // Start is called before the first frame update
    void Start()
    {
        user=FindObjectOfType<UserScore>();
    
        aux=100;
        tiempoIn=0;
        tiempoMax=2;
        tamCartas=Random.Range(0,Cartas.Count);
        GameObject NewObst=Instantiate(obst);
        NewObst.transform.position=transform.position + new Vector3(0,0,0);
        altura=1.5f;
       
        
    }
    void instanciar()
    {
        GameObject NewObst=Instantiate(obst);
        NewObst.transform.position=transform.position + new Vector3(0,Random.Range(-altura,altura),0);

        if(user.userScore%(100+aux)==0&&Cartas.Count!=0)
        {
       
            GameObject hijo =Instantiate(Carta) as GameObject;
           // int cont=0;
            hijo.transform.parent=NewObst.transform;
            hijo.transform.position=NewObst.transform.position+ new Vector3(0,0.5f,168.57f);
            hijo.gameObject.GetComponent<SpriteRenderer>().sprite=Cartas[tamCartas];


            aux+=250;
        }

    }
 

    // Update is called once per frame
    void Update()
    {
        if(tiempoIn>tiempoMax)
        {   instanciar();
           
            //Destroy(gameObject,10); 
            tiempoIn=0;

        }
        else
        {
            tiempoIn+=Time.deltaTime;

        }
        

        
       
        
    }
     public void Nivel()
        {
          
            if(tiempoMax>0.5)
            {
                tiempoMax=tiempoMax-0.2f;
            }

        

        }
}
