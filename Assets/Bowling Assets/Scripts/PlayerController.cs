using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerMovementSpeed = 1.0f;
    public float arrowMinPosition = -0.25f;
    public float arrowMaxPosition = 0.25f;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moving without constraints
        horizontalInput = Input.GetAxis("Horizontal");
        transform.position += transform.right * horizontalInput * playerMovementSpeed * Time.deltaTime;

        // Moving with constraints
        float movePosition = Input.GetAxis("Horizontal") * playerMovementSpeed * Time.deltaTime;
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x + movePosition, arrowMinPosition, arrowMinPosition),
                transform.position.y,
                transform.position.z
            );
    }
}
