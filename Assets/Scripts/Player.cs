using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float vel;
    public bool Play;
    Rigidbody2D rb;
    UIGame GM;
    UserScore user;
    // Start is called before the first frame update
    void Start()
    {
        user=FindObjectOfType<UserScore>();
        rb=GetComponent<Rigidbody2D>();
        GM=FindObjectOfType<UIGame>();
        vel=4f;
  
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if( Input.GetMouseButtonDown(0))
        {
            rb.velocity=Vector2.up*vel;
        }
        
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        GM.GameOver();

    }
  
}
