using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TraderController : MonoBehaviour
{
    public EconomyManager EconomyManager;
    public PlayerHealth PlayerHealth;
    public float deactivateTime = 2f;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject message;
    [SerializeField] private GameObject message1;
    private bool checkGold;
    // Start is called before the first frame update
    void Start()
    {
        EconomyManager = GetComponent<EconomyManager>();
        PlayerHealth = GetComponent<PlayerHealth>();
        


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && message1.activeSelf)
        {
            panel.SetActive(true);
            checkGold = EconomyManager.AfterTrade();
        }
    }
    public void ChooseHealth()
    {
        if (checkGold)
        {
            PlayerHealth.UpdateMaxHeath();
            panel.SetActive(false);
            message.SetActive(true);
            StartCoroutine(DeactivateAfterDelay());
        }
        else
        {
            panel.SetActive(false);
            message.SetActive(true);
            StartCoroutine(DeactivateAfterDelay());
        }
        
    }
    IEnumerator DeactivateAfterDelay()
    {
        // Ð?i m?t kho?ng th?i gian
        yield return new WaitForSeconds(deactivateTime);

        // Sau khi ð?i xong, vô hi?u hóa GameObject
        message.SetActive(false);
    }
    public void ChooseStamina()
    {
        
        panel.SetActive(false);
    }
}
