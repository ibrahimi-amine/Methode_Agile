﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public  bool isPaused = false;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

     
    
    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

public void Resume (){
    pauseMenu.SetActive(false);
    Time.timeScale = 1f;
    isPaused = false;
    
}

void Pause (){
    pauseMenu.SetActive(true);
    Time.timeScale = 0f;
    isPaused = true;
    Debug.Log("Game paused");	
}

}
