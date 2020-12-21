using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    float TimeInterval ;
    // Start is called before the first frame update
    void Start()
    {        
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
                        TimeInterval = 0;
                    }
                }
                else{  
                    if(Input.anyKeyDown){
                        Vector3 position = this.transform.position;
                        position.x--;
                        this.transform.position = position;
                        TimeInterval = 0;
                    }
                }
           // }
        
    }
}
