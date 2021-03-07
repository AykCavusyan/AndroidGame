using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Move();

    }

    void Move()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Ball"))
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
            Destroy(collision.gameObject);

            
        }
        
    }

    
}
