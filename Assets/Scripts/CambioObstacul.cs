using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioObstacul : MonoBehaviour
{
    public List<Sprite> obstaculos;
     public GameObject CambioObst;
    int ranObs;
    // Start is called before the first frame update
    void Awake()
    {
        ranObs=Random.Range(0,obstaculos.Count);
        
    }

    // Update is called once per frame
    public void Start()
    {
        CambioObst.gameObject.GetComponent<SpriteRenderer>().sprite=obstaculos[ranObs];
        ranObs=Random.Range(0,obstaculos.Count);

    }
}
