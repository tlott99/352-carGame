using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision2 : MonoBehaviour
{
    // Start is called before the first frame update
[SerializeField] Color hasPackageColor = Color.green;
    [SerializeField] Color noPackageColor = Color.white;
    SpriteRenderer spriteRenderer;
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    bool hasPackage = false;
    private void OnCollisionEnter2D(Collision2D other) {

        if (other.gameObject.tag == "House"){
            Driver2.speedSlow2();
        }
        else if (other.gameObject.tag == "Tree"){
            Driver2.speedSlow2();
        }
        else if (other.gameObject.tag == "Rock"){
            Driver2.speedSlow2();
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Packages" && !hasPackage){
            Debug.Log("Picked up new package");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, .5f);
        }
        else if(other.gameObject.tag == "Human" && hasPackage){
            Debug.Log("Dropped off package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            ScoreCounter.scoreAmount += 1;
            ScoreCounter.addPoint();
        } 
        else if (other.gameObject.tag =="Water"){
            Driver2.waterSlow2();
        }
        else if (other.gameObject.tag == "Boost"){
            Driver2.speedBoost2();
        } 
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Water"){
            Driver2.waterSpeed2();
        }
    }
}
