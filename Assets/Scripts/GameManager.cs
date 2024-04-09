using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] BirdMovement bird;
    [SerializeField] ObstacleSpwanner obstacleSpawner;
    [SerializeField] UiManager uiManager;
    private int score;
    private int scoremultiplier = 1;
    private void Awake()
    {
        Time.timeScale = 0;
        bird.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        uiManager.StartWindow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        bird.ResetPosition();
        Time.timeScale = 1;
        bird.gameObject.SetActive(true);
        obstacleSpawner.GameOver(false);
        score = 0;
        uiManager.UpdateScore(score);
    }

    public void GameOver()
    {
        //Time.timeScale = 0;
        obstacleSpawner.GameOver(true);
        bird.gameObject.SetActive(false);
        uiManager.GameOver();
    }

    public void AddScore()
    {
        score += scoremultiplier;
        //Debug.Log(score);
        uiManager.UpdateScore(score);
    }
}
