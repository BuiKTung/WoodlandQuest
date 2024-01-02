using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyaudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        GameObject audioObject = GameObject.Find("SoundManager 1");
        if (Input.GetKeyUp(KeyCode.E))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    
}
