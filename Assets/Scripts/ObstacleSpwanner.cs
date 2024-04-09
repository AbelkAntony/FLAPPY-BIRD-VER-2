using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpwanner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float timeIntervel;
    private float spawnPosition;

    private float timer;

    private void Start()
    {
        timer = timeIntervel;
    }
   /* private void Update()
    {
        if (Time.time >= timer)
        {
            GameObject obstacle = Instantiate(pipe, this.transform.position, Quaternion.identity);
            Destroy(obstacle, 5);
            timer += timeIntervel;
        }
    }*/

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
        GameObject obstacle = Instantiate(pipe, this.transform.position, Quaternion.identity);
        Destroy(obstacle, 5);
    }
}
