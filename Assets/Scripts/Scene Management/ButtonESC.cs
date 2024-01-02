using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonESC : MonoBehaviour
{
    public GameObject panel; 
    private bool isPanelActive = true;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (panel != null && isPanelActive)
            {
                panel.SetActive(false);
                isPanelActive = false;
            }
            else if (panel != null)
            {
                panel.SetActive(true);
                isPanelActive = true;
            }
        }
    }
   
}
