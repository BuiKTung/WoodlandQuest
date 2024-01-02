using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class ExitToMenu : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject UIcanva;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y) && menu.activeSelf)
        { 
            menu.SetActive(false);
            GoToMenu();
           
            
        }
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
        Destroy(UIcanva);

    }

  
}
