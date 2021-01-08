using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpriteController : MonoBehaviour
{
    float TimeInterval ;
    int score;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 minScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
    	Vector3 maxScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        TimeInterval += Time.deltaTime;
        anim.SetBool("isWalking", false);
        anim.SetBool("isWalkingBack", false);
        anim.SetBool("isIdle", true);

                if ((8.0-0.5 <= TimeInterval && TimeInterval < 8.5)||
                (13.333-0.5 <= TimeInterval && TimeInterval < 13.833)||
                (14.667-0.5 <= TimeInterval && TimeInterval < 15.167)||
                (19.333-0.5 <= TimeInterval && TimeInterval < 19.833)||
                (20.667-0.5 <= TimeInterval && TimeInterval < 21.167)||
                (24.0-0.5 <= TimeInterval && TimeInterval < 24.5)||
                (24.667-0.5 <= TimeInterval && TimeInterval < 25.167)||
                (25.333-0.5 <= TimeInterval && TimeInterval < 25.833)||
                (29.333-0.5 <= TimeInterval && TimeInterval < 29.833)||
                (30.667-0.5<= TimeInterval && TimeInterval < 31.167)||
                (31.333-0.5<= TimeInterval && TimeInterval < 31.833)||
                (36.0-0.5 <= TimeInterval && TimeInterval < 36.5)||
                (38.333-0.5 <= TimeInterval && TimeInterval < 38.833)||
                (39.0-0.5 <= TimeInterval && TimeInterval < 39.5)||
                (45.333-0.5 <= TimeInterval && TimeInterval < 45.833)||
                (47.333-0.5 <= TimeInterval && TimeInterval < 47.833)||
                (51.333-0.5 <= TimeInterval && TimeInterval < 51.833)||
                (56.667-0.5 <= TimeInterval && TimeInterval < 57.167)||
                (57.333-0.5 <= TimeInterval && TimeInterval < 57.833)||
                (58.0-0.5 <= TimeInterval && TimeInterval < 58.5)||
                (66.667-0.5 <= TimeInterval && TimeInterval < 67.167)||
                (67.103-0.5<= TimeInterval && TimeInterval < 67.603)||
                (67.333-0.5 <= TimeInterval && TimeInterval < 67.833)||
                (68.0-0.5 <= TimeInterval && TimeInterval < 68.5)||
                (68.667-0.5<= TimeInterval && TimeInterval < 69.167)||
                (72.0-0.5 <= TimeInterval && TimeInterval < 72.5)||
                (72.667-0.5 <= TimeInterval && TimeInterval < 73.167)||
                (73.333-0.5 <= TimeInterval && TimeInterval < 73.833)||
                (73.769-0.5 <= TimeInterval && TimeInterval < 74.269)||
                (74.0-0.5 <= TimeInterval && TimeInterval < 74.5)||
                (77.333-0.5 <= TimeInterval && TimeInterval < 77.833)||
                (78.0-0.5 <= TimeInterval && TimeInterval < 78.5)||
                (78.667-0.5 <= TimeInterval && TimeInterval < 79.167)||
                (79.333-0.5 <= TimeInterval && TimeInterval < 79.833)||
                (79.769-0.5 <= TimeInterval && TimeInterval < 80.269)||
                (82.667-0.5 <= TimeInterval && TimeInterval < 83.167)||
                (83.333-0.5 <= TimeInterval && TimeInterval < 83.833)||
                (83.769-0.5 <= TimeInterval && TimeInterval < 84.769)||
                (88.0-0.5 <= TimeInterval && TimeInterval < 88.5)||
                (88.436-0.5 <= TimeInterval && TimeInterval < 88.936)||
                (88.667-0.5 <= TimeInterval && TimeInterval < 89.167)||
                (89.333-0.5 <= TimeInterval && TimeInterval < 89.833)||
                (94.436-0.5 <= TimeInterval && TimeInterval < 94.936)||
                (95.333-0.5 <= TimeInterval && TimeInterval < 95.833)||
                (98.667-0.5 <= TimeInterval && TimeInterval < 99.167)||
                (99.769-0.5 <= TimeInterval && TimeInterval < 100.269)||
                (100.0-0.5<= TimeInterval && TimeInterval < 100.5)||
                (101.103-0.5 <= TimeInterval && TimeInterval < 101.603)||
                (104.436-0.5 <= TimeInterval && TimeInterval < 104.936)||
                (104.667-0.5 <= TimeInterval && TimeInterval < 104.167)||
                (105.333-0.5 <= TimeInterval && TimeInterval < 105.833)||
                (106.0-0.5 <= TimeInterval && TimeInterval < 106.5)||
                (109.769-0.5 <= TimeInterval && TimeInterval < 110.269)||
                (110.0-0.5 <= TimeInterval && TimeInterval < 110.5)||
                (111.103-0.5 <= TimeInterval && TimeInterval < 111.603)||
                (111.333-0.5 <= TimeInterval && TimeInterval < 111.833)||
                (114.667-0.5 <= TimeInterval && TimeInterval < 115.167)||
                (115.333-0.5 <= TimeInterval && TimeInterval < 115.833)||
                (115.769-0.5 <= TimeInterval && TimeInterval < 116.269)||
                (116.667-0.5 <= TimeInterval && TimeInterval < 117.167)||
                (117.103-0.5 <= TimeInterval && TimeInterval < 117.603)
                ){
                    if(Input.anyKeyDown){
                        anim.SetBool("isWalking", true);
                        anim.SetBool("isWalkingBack", false);
                        anim.SetBool("isIdle", false);
                        Vector3 position = this.transform.position;
                        position.x++;
                        this.transform.position = position;
                        score += (int)(1);
                        //TimeInterval = 0;

                        print("The score is :"+score);
                        //SetScoreText();
                    }
                }
                else{
                    if(Input.anyKeyDown){
                        anim.SetBool("isWalkingBack", true);
                        anim.SetBool("isWalking", false);
                        anim.SetBool("isIdle", false);
                        Vector3 position = this.transform.position;
                        position.x--;
                        this.transform.position = position;

                        score -= (int)(1);
                      //  TimeInterval = 0;
                        print("The score is :"+score);
                    }
                }

		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10, 75), transform.position.y, transform.position.z);
    }

}
