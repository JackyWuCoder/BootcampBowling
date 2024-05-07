using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check for collision with an object
        // Debug.Log("Ball has collided with " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Pin"))
        {
            Debug.Log("The object we collided with is " + collision.gameObject.name);
        }
    }
}
