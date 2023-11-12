using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UImanager : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI score;

    public void TurnOnUI() {
        panel.SetActive(true);
    }

    public void HideUI() {
        panel.SetActive(false);
    }

    public void Defeat()
    {
        score.text = score.ToString();
        TurnOnUI();
    }
                
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
        
            
}