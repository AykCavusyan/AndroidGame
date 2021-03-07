using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTestScript : MonoBehaviour
{

    public GameObject player;

    public float maxTime;
    public float minSwipeDistance;

    float startTime;
    float endTime;

    Vector3 startPos;
    Vector3 endPos;

    float swipedDistance;
    float swipedTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                startTime = Time.time;
                startPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTime = Time.time;
                endPos = touch.position;

                swipedDistance = (endPos - startPos).magnitude;
                swipedTime = endTime - startTime;

                if (swipedTime < maxTime && swipedDistance > minSwipeDistance)
                {
                    Swipe();
                }
            }
        }
    }

    public void Swipe()
    {
        Vector2 distance = endPos - startPos;
        
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(distance.x, distance.y));
       
        
    }



}

