using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]  float steerSpeed = .05f;
    [SerializeField]  float moveSpeed = .0005f;
    
    public static float waterEffect = 1;
    public static float boostEffect = 1;
    public static void speedBoost(){
        boostEffect = 2;
    }
    public static void speedSlow(){
        boostEffect = 1;
    }
    public static void waterSlow(){
        waterEffect = .5f;
    }
    public static void waterSpeed(){
        waterEffect = 1;
    }
    


    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")* Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical")* Time.deltaTime;
        transform.Rotate(0,0,-steerAmount * steerSpeed * waterEffect);
        transform.Translate(0,moveAmount * moveSpeed * waterEffect * boostEffect,0);
    }
}