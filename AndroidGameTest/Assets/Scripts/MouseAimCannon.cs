using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

public class MouseAimCannon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    


    // Update is called once per frame
    void Update()
    {
        AimingSystem();
        ShootingSystem();
    }

    private void AimingSystem()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle - 90);
       
        
    }

    private void ShootingSystem()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            
        }
    }

    

}
