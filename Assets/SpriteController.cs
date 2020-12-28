using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    float TimeInterval ;
    
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

                if (0.5 <= TimeInterval && TimeInterval < 1.0){
                    if(Input.anyKeyDown){
                        anim.SetBool("isWalking", true);
                        anim.SetBool("isWalkingBack", false);
                        anim.SetBool("isIdle", false);
                        Vector3 position = this.transform.position;
                        position.x++;
                        this.transform.position = position;
                        TimeInterval = 0;
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
                        TimeInterval = 0;
                        
                    }
                } 
        
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10, 75), transform.position.y, transform.position.z);
    }
    
}
