using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    public float force;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * force;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "pipe")
        {
            gameManager.GameOver();
            
            Debug.Log(collision.gameObject.tag);
            
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "scoreCalculator")
        {
            gameManager.AddScore();
            //Debug.Log(collision.gameObject.tag);
        }
    }

    public void ResetPosition()
    {
        this.gameObject.transform.position = new Vector3(0, 0, 0);
    }
}
