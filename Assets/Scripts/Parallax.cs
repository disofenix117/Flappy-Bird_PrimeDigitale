using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Material material;
    public float paralax=2f;
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sp=GetComponent<SpriteRenderer>();
        material=sp.material;
        offset=material.mainTextureOffset;
        
    }

    // Update is called once per frame
    void Update()
    {
        offset.x+=Time.deltaTime/paralax;
        material.mainTextureOffset=offset;
        
    }
}
