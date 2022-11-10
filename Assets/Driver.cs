using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]    float steerSpeed = .05f;
    [SerializeField]    float moveSpeed = .0005f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")* Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical")* Time.deltaTime;
        transform.Rotate(0,0,-steerAmount * steerSpeed);
        transform.Translate(0,moveAmount * moveSpeed,0);
    }
}