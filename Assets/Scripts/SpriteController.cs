using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpriteController : MonoBehaviour
{
    float TimeInterval ;
    public int score = 0;
    Animator anim;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 minScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
    	//Vector3 maxScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        TimeInterval += Time.deltaTime;
        anim.SetBool("isWalking", false);
        anim.SetBool("isWalkingBack", false);
        anim.SetBool("isIdle", true);
        anim.SetBool("NextLevel", false);

                if (
                (8.0-0.25 <= TimeInterval && TimeInterval < 8.5-0.25)||
                (13.333-0.25 <= TimeInterval && TimeInterval < 13.833-0.25)||
                (14.667-0.25 <= TimeInterval && TimeInterval < 15.167-0.25)||
                (19.333-0.25 <= TimeInterval && TimeInterval < 19.833-0.25)||
                (20.667-0.25 <= TimeInterval && TimeInterval < 21.167-0.25)||
                (24.0-0.25 <= TimeInterval && TimeInterval < 24.5-0.25)||
                (24.667-0.25 <= TimeInterval && TimeInterval < 25.167-0.25)||
                (25.333-0.25 <= TimeInterval && TimeInterval < 25.833-0.25)||
                (29.333-0.25 <= TimeInterval && TimeInterval < 29.833-0.25)||
                (30.667-0.25<= TimeInterval && TimeInterval < 31.167-0.25)||
                (31.333-0.25<= TimeInterval && TimeInterval < 31.833-0.25)||
                (36.0-0.25 <= TimeInterval && TimeInterval < 36.5-0.25)||
                (41.333-0.25 <= TimeInterval && TimeInterval < 41.833-0.25)||
                (42.0-0.25 <= TimeInterval && TimeInterval < 42.5-0.25)||
                (45.333-0.25 <= TimeInterval && TimeInterval < 45.833-0.25)||
                (47.333-0.25 <= TimeInterval && TimeInterval < 47.833-0.25)||
                (51.333-0.25 <= TimeInterval && TimeInterval < 51.833-0.25)||
                (56.667-0.25 <= TimeInterval && TimeInterval < 57.167-0.25)||
                (57.333-0.25 <= TimeInterval && TimeInterval < 57.833-0.25)||
                (58.0-0.25 <= TimeInterval && TimeInterval < 58.5-0.25)||
                (63.333-0.25 <= TimeInterval && TimeInterval < 63.833-0.25)||
                (66.667-0.25 <= TimeInterval && TimeInterval < 67.167-0.25)||
                (67.103-0.25<= TimeInterval && TimeInterval < 67.603-0.25)||
                (67.333-0.25 <= TimeInterval && TimeInterval < 67.833-0.25)||
                (68.0-0.25 <= TimeInterval && TimeInterval < 68.5-0.25)||
                (68.667-0.25<= TimeInterval && TimeInterval < 69.167-0.25)||
                (72.0-0.25 <= TimeInterval && TimeInterval < 72.5-0.25)||
                (72.667-0.25 <= TimeInterval && TimeInterval < 73.167-0.25)||
                (73.333-0.25 <= TimeInterval && TimeInterval < 73.833-0.25)||
                (73.769-0.25 <= TimeInterval && TimeInterval < 74.269-0.25)||
                (74.0-0.25 <= TimeInterval && TimeInterval < 74.5-0.25)||
                (77.333-0.25 <= TimeInterval && TimeInterval < 77.833-0.25)||
                (78.0-0.25 <= TimeInterval && TimeInterval < 78.5-0.25)||
                (78.667-0.25 <= TimeInterval && TimeInterval < 79.167-0.25)||
                (79.333-0.25 <= TimeInterval && TimeInterval < 79.833-0.25)||
                (79.769-0.25 <= TimeInterval && TimeInterval < 80.269-0.25)||
                (82.667-0.25 <= TimeInterval && TimeInterval < 83.167-0.25)||
                (83.333-0.25 <= TimeInterval && TimeInterval < 83.833-0.25)||
                (83.769-0.25 <= TimeInterval && TimeInterval < 84.769-0.25)||
                (84.0-0.25 <= TimeInterval && TimeInterval < 84.5-0.25)||
                (88.0-0.25 <= TimeInterval && TimeInterval < 88.5-0.25)||
                (88.436-0.25 <= TimeInterval && TimeInterval < 88.936-0.25)||
                (88.667-0.25 <= TimeInterval && TimeInterval < 89.167-0.25)||
                (89.333-0.25 <= TimeInterval && TimeInterval < 89.833-0.25)||
                (93.333-0.25 <= TimeInterval && TimeInterval < 93.833-0.25)||
                (94.436-0.25 <= TimeInterval && TimeInterval < 94.936-0.25)||
                (95.333-0.25 <= TimeInterval && TimeInterval < 95.833-0.25)||
                (98.667-0.25 <= TimeInterval && TimeInterval < 99.167-0.25)||
                (99.769-0.25 <= TimeInterval && TimeInterval < 100.269-0.25)||
                (100.0-0.25<= TimeInterval && TimeInterval < 100.5-0.25)||
                (101.103-0.25 <= TimeInterval && TimeInterval < 101.603-0.25)||
                (104.436-0.25 <= TimeInterval && TimeInterval < 104.936-0.25)||
                (104.667-0.25 <= TimeInterval && TimeInterval < 104.167-0.25)||
                (105.333-0.25 <= TimeInterval && TimeInterval < 105.833-0.25)||
                (106.0-0.25 <= TimeInterval && TimeInterval < 106.5-0.25)||
                (109.769-0.25 <= TimeInterval && TimeInterval < 110.269-0.25)||
                (110.0-0.25 <= TimeInterval && TimeInterval < 110.5-0.25)||
                (111.103-0.25 <= TimeInterval && TimeInterval < 111.603-0.25)||
                (111.333-0.25 <= TimeInterval && TimeInterval < 111.833-0.25)||
                (114.667-0.25 <= TimeInterval && TimeInterval < 115.167-0.25)||
                (115.333-0.25 <= TimeInterval && TimeInterval < 115.833-0.25)||
                (115.769-0.25 <= TimeInterval && TimeInterval < 116.269-0.25)||
                (116.667-0.25 <= TimeInterval && TimeInterval < 117.167-0.25)||
                (117.103-0.25 <= TimeInterval && TimeInterval < 117.603-0.25)||
                (120.667-0.25 <= TimeInterval && TimeInterval < 120.667+0.25)||
                (121.103-0.25 <= TimeInterval && TimeInterval < 121.103+0.25)||
                (121.333-0.25 <= TimeInterval && TimeInterval < 121.333+0.25)||
                (121.769-0.25 <= TimeInterval && TimeInterval < 121.769+0.25)||
                (122.0-0.25 <= TimeInterval && TimeInterval < 122.0+0.25)||
                (126.0-0.25 <= TimeInterval && TimeInterval < 126.0+0.25)||
                (126.436-0.25 <= TimeInterval && TimeInterval < 126.436+0.25)||
                (126.667-0.25 <= TimeInterval && TimeInterval < 126.667+0.25)||
                (127.103-0.25 <= TimeInterval && TimeInterval < 127.103+0.25)||
                (127.333-0.25 <= TimeInterval && TimeInterval < 127.333+0.25)||
                (127.769-0.25 <= TimeInterval && TimeInterval < 127.769+0.25)
                ){
                    if(Input.anyKeyDown){
                         if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1) || Input.GetKey(KeyCode.Escape)) {
                        return;
                        }  
                        anim.SetBool("isWalking", true);
                        anim.SetBool("isWalkingBack", false);
                        anim.SetBool("isIdle", false);
                        anim.SetBool("NextLevel", false);

                        audioSource= GetComponent<AudioSource>();
                        audioSource.Play();
                        Vector3 position = this.transform.position;
                        position.x++;
                        this.transform.position = position;
                        score += (int)(1);
                        scoreScript.scoreValue += 1;
                        //TimeInterval = 0;

                        print("The score is :"+score);
                        //SetScoreText();
                    }
                }
                else{
                    if(Input.anyKeyDown){
                         if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1) || Input.GetKey(KeyCode.Escape)) {
                        return;
                        }  
                        anim.SetBool("isWalkingBack", true);
                        anim.SetBool("isWalking", false);
                        anim.SetBool("isIdle", false);
                        anim.SetBool("NextLevel", false);

                        audioSource= GetComponent<AudioSource>();
                        audioSource.Play();
                        Vector3 position = this.transform.position;
                        position.x--;
                        this.transform.position = position;
                        score -= (int)(1);
                        scoreScript.scoreValue -= 1;


                      //  TimeInterval = 0;
                        print("The score is :"+score);
                    }
                }
                  if(score >= 75 && TimeInterval > 128.0){
                    anim.SetBool("isWalkingBack", false);
                    anim.SetBool("isWalking", false);
                    anim.SetBool("isIdle", false);
                    anim.SetBool("NextLevel", true);
                    
                }

	transform.position = new Vector3(Mathf.Clamp(transform.position.x, -42, 50), transform.position.y, transform.position.z);

    }

}
