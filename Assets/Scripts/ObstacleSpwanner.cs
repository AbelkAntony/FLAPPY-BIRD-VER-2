using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpwanner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float timeIntervel;

    private float timer;

    private void Start()
    {
        timer = timeIntervel;
    }
    private void Update()
    {
        if (Time.time >= timer)
        {
            GameObject obstacle =  Instantiate(pipe, this.transform.position, Quaternion.identity);
            Destroy(obstacle, 5);
            timer += timeIntervel;
        }
    }
}
