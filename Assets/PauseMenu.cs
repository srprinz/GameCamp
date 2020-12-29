using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    
    public Button pauseButton;


    // Gets music for Conductor class
    //public AudioSource musicSource; 
    AudioSource musicSource = GameObject.Find("musicSource").GetComponent<AudioSource>();


    // Start is called before the first frame update
    void Start()
    {


        //Listens for a button click
        pauseButton.onClick.AddListener(TaskOnClick);
    }

    // On click, pause if music is playing, play if not
    void TaskOnClick()
    {
        if (musicSource.isPlaying)
        {
            musicSource.Pause();
        }
        else
        {
            musicSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
