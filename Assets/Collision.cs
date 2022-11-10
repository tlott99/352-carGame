using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    float number = 0.5f;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("ouchie");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("you're stuck in water");
    }
    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log("you got out");
    }
}
