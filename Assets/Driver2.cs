using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver2 : MonoBehaviour
{
    // Start is called before the first frame update    [SerializeField]  float steerSpeed = .05f;
    [SerializeField]  float steerSpeed = .05f;
    [SerializeField]  float moveSpeed = .0005f;
    
    public static float waterEffect = 1;
    public static float boostEffect = 1;
    public static void speedBoost2(){
        boostEffect = 2;
    }
    public static void speedSlow2(){
        boostEffect = 1;
    }
    public static void waterSlow2(){
        waterEffect = .5f;
    }
    public static void waterSpeed2(){
        waterEffect = 1;
    }
    


    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Fire1")* Time.deltaTime;
        float moveAmount = Input.GetAxis("Fire2")* Time.deltaTime;
        transform.Rotate(0,0,-steerAmount * steerSpeed * waterEffect);
        transform.Translate(0,moveAmount * moveSpeed * waterEffect * boostEffect,0);
    }
}