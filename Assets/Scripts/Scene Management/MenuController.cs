using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public int time;
    public void Awake()
    {
       
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitMenu()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }


    
      

    public void StartGame()
    {
        if (PlayerPrefs.HasKey("FirstPlay")==false)
        {
            
           
            NewGame();
        }
        else
        {
            
            PlayerPrefs.SetInt("FirstPlay", 1);
            
            LoadIntro();
        }
       
        
    }

    void LoadIntro()
    {
        // Load scene intro
        SceneManager.LoadScene("Intro");
    }

    


}
