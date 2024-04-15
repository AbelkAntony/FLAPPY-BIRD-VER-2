using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpwanner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float timeIntervel;
    private Vector3 spawnPosition;

    private float timer;

    private void Start()
    {
        timer = timeIntervel;
    }
  

    public void GameOver(bool gameOver)
    {
        if(gameOver)
        {
            CancelInvoke();
        }
        else
        {
            InvokeRepeating("SpawnPipe",5,timeIntervel);
        }
    }

    private void SpawnPipe()
    {
        spawnPosition = this.transform.position + new Vector3(0, Random.Range(-4,4), 0); 
        GameObject obstacle = Instantiate(pipe, spawnPosition, Quaternion.identity);
        Destroy(obstacle, 5);
    }
}
