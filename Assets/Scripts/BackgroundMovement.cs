using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -9)
        {
            transform.position = new Vector3(15,0,0);
        }
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
