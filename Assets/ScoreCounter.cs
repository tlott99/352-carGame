using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static int scoreAmount;
    public static TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreAmount = 0;
    }

    // Update is called once per frame
    void Update(){
        
    }
    public static void addPoint(){
        scoreText.text = "Packages Delivered: " + scoreAmount.ToString();
    }
}
