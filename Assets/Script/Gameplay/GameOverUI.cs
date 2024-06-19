using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private Button retryButton, mainMenuButton;

    [SerializeField] private TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        retryButton.onClick.AddListener(RetryGame);
        mainMenuButton.onClick.AddListener(ToMainMenu);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void RetryGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
