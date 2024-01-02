using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource Musix;
    [SerializeField] AudioSource SFX;
    

    [Header("-----------------------------------------------")]
    public AudioClip background;
    public AudioClip backgroundboss;
    public AudioClip death;
    
    public AudioClip touch;
    public AudioClip dash;
    public AudioClip attack_sword;
    public AudioClip attack_magic;
    public AudioClip arrow;
    public AudioClip take_coin;
    private static GameObject persistentObject;
    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (persistentObject == null)
        {

            persistentObject = this.gameObject;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            
            Destroy(gameObject);
        }
    }
    private void Start()
    {

        Musix.clip = background;
        Musix.Play();
    }
           
        
    
    public void PlaySFX(AudioClip clip)
    {
        SFX.PlayOneShot(clip);
    }
}
