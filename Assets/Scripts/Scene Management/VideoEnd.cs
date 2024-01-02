using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoEnd : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    

    void Start()
    {
        
        videoPlayer.loopPointReached += OnVideoEnd;
        
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        
        SceneManager.LoadScene(1);
    }

}
