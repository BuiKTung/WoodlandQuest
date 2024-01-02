using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class HelpController : MonoBehaviour
{
   
    [SerializeField] private GameObject panel;
    private bool isPanelActive = true;

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
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
