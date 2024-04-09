using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject bird;
    [SerializeField] ObstacleSpwanner obstacleSpawner;
    [SerializeField] UiManager uiManager;
    private void Awake()
    {
        Time.timeScale = 0;
        bird.SetActive(false);
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
        Time.timeScale = 1;
        bird.SetActive(true);
        obstacleSpawner.GameOver(false);
    }

    public void GameOver()
    {
        //Time.timeScale = 0;
        obstacleSpawner.GameOver(true);
        bird.gameObject.SetActive(false);
        uiManager.GameOver();
    }
}
