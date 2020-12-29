using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpriteController : MonoBehaviour
{
    float TimeInterval ;
    int score;
    public Text playerScore;

//go
    // Start is called before the first frame update
    void Start()
    {
      //playerScore = GetComponent<Text>();
      //SetScoreText();
    }

    // Update is called once per frame
    void Update()
    {
    TimeInterval += Time.deltaTime;
                if (0.5 <= TimeInterval && TimeInterval < 1.0){
                    if(Input.anyKeyDown){
                        Vector3 position = this.transform.position;
                        position.x++;
                        this.transform.position = position;
                        score += (int)(TimeInterval*20);
                        TimeInterval = 0;

                        print("The score is :"+score);
                        //SetScoreText();
                    }
                }
                else{
                    if(Input.anyKeyDown){
                        Vector3 position = this.transform.position;
                        position.x--;
                        this.transform.position = position;

                        score -= (int)(TimeInterval*5);
                        TimeInterval = 0;
                        print("The score is :"+score);
                        //SetScoreText();
                    }
                }


    }

    //void SetScoreText ()
     //{
        // playerScore.GetComponent<Text>().text = "Stamina: " + score;
     //}


}
