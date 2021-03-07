using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchTestScript : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //    if (Input.touchCount > 0)
        //    //foreach(Touch touch in Input.touches)
        //    //    Debug.Log(touch.position);
        //    {
        //        if (Input.GetTouch(0).phase == TouchPhase.Began)
        //        {
        //            Debug.Log("Touch Begins!");
        //        }
        //        if (Input.GetTouch(0).phase == TouchPhase.Moved)
        //    {
        //        Debug.Log("Touch Moved!");
        //    }
        //        if (Input.GetTouch(0).phase == TouchPhase.Ended)
        //    {
        //        Debug.Log("Touchphase Ended!");
        //    }
        //    }

        if (Input.touchCount > 0) 
        { 
        ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Debug.DrawRay(ray.origin, ray.direction * 40, Color.red);
            
            
            // getting output info from the hitted object -- hitted object is stored inside the hif variable which is of class RaycastHit
        if (Physics.Raycast(ray, out hit,Mathf.Infinity))
            {

                if (hit.transform.gameObject.tag == "Enemy") 
                {
            Destroy(hit.transform.gameObject);
            Debug.Log("Hit Something");
                }
            }
        }
    }


}
