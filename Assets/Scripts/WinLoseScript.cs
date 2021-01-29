using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseScript : MonoBehaviour
{
    public GameObject winMessageUI; 
    public GameObject loseMessageUI; 
    public bool hello = true;


    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if(SpriteController.score >= 75 && SpriteController.TimeInterval > 128.0){
            winMessageUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else if(SpriteController.score <= 75 && SpriteController.TimeInterval > 128.0){
            loseMessageUI.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }
}
