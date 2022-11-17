using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]  float steerSpeed = .05f;
    [SerializeField]  float moveSpeed = .0005f;
    
    public static float waterEffect = 1;
    public static void waterSlow(){
        waterEffect = .5f;
    }
    public static void waterSpeed(){
        waterEffect = 1;
    }
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    Sprite spriteDefault;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteDefault = spriteRenderer.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")* Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical")* Time.deltaTime;
        transform.Rotate(0,0,-steerAmount * steerSpeed * waterEffect);
        transform.Translate(0,moveAmount * moveSpeed * waterEffect,0);
    }
}