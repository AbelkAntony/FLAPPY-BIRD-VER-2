using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject gameName;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject playButton;
    public void StartWindow()
    {
        gameName.SetActive(true);
        playButton.SetActive(true);
    }
    private void Default()
    {
        gameName.SetActive(false);
        gameOver.SetActive(false);
        playButton.SetActive(false);
    }

    public void StartButton()
    {
        gameManager.StartGame();
        Default();
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
    }
}
