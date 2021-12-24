using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public float vel;
    UserScore user;

    
    // Start is called before the first frame update
    void Start()
    {
        user=FindObjectOfType<UserScore>();
        vel =8f;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+=Vector3.left*vel*Time.deltaTime;
         Destroy(gameObject,10);
        
    }
  
}
