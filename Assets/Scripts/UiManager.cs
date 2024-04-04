using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] GameObject gameName;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject playButton;
    void Awake()
    {
        gameName.SetActive(false);

    }

    public void StartGame()
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
}
