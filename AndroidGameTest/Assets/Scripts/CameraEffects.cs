using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffects : MonoBehaviour
{

    private float shakeTime, shakePower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartShake(float lenght, float power)
    {
        shakeTime = lenght;
        shakePower = power;

    }
}
