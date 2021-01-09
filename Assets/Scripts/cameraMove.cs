using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
        private float moveSpeed = 0.5f;
        public Transform target; // Drop the player in the inspector of the camera
        
        void Update()
        {
            Vector3 newPosition = new Vector3(
            Mathf.Clamp(target.position.x, -200, 200),
            transform.position.y, 
            transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPosition, moveSpeed * Time.deltaTime);
        }
    }  
