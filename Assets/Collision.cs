using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    bool hasPackage = false;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("ouchie");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Packages" && !hasPackage){
            Debug.Log("Picked up new package");
            hasPackage = true;
            Destroy(other.gameObject, .5f);
        }
        else if(other.gameObject.tag == "Human" && hasPackage){
            Debug.Log("Dropped off package");
            hasPackage = false;
            ScoreCounter.scoreAmount += 1;
            ScoreCounter.addPoint();
        } 
        else if (other.gameObject.tag =="Water"){
            Driver.waterSlow();
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Water"){
            Driver.waterSpeed();
        }
    }
}
