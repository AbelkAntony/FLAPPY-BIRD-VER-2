using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] UiManager uiManager;
    private void Awake()
    {
        Time.timeScale = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        uiManager.StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
