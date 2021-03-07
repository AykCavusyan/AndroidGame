using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float randScaleNo;
    
    // Start is called before the first frame update
    void Start()
    {
        randScaleNo = Random.Range(1f, 2f);
        
        GetComponent<SpriteRenderer>().material.color = Random.ColorHSV();
        transform.localScale = new Vector3(randScaleNo, randScaleNo, randScaleNo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

}
