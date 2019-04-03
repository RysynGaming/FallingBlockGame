using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Text secondsSurvivedUI;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnGameOver()
    {
        gameOverScreen.SetActive(true);
        secondsSurvivedUI.text = Time.time.ToString();
    }
}
