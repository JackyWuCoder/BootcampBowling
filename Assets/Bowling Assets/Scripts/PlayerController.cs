using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerMovementSpeed = 1.0f;
    public float arrowMinPosition = -0.25f;
    public float arrowMaxPosition = 0.25f;
    public Transform throwingArrow;
    public Transform ball;
    private float horizontalInput;
    private Vector3 ballOffset;

    // Start is called before the first frame update
    void Start()
    {
        ballOffset = ball.position - throwingArrow.position;
    }

    // Update is called once per frame
    void Update()
    {
        //MoveArrowWithoutConstraints();
        MoveArrowWithConstraints();
    }

    private void MoveArrowWithoutConstraints()
    {
        // Moving without constraints
        horizontalInput = Input.GetAxis("Horizontal");
        throwingArrow.position += throwingArrow.right * horizontalInput * playerMovementSpeed * Time.deltaTime;
    }

    private void MoveArrowWithConstraints()
    {
        // Moving with constraints
        float movePosition = Input.GetAxis("Horizontal") * playerMovementSpeed * Time.deltaTime;
        throwingArrow.position = new Vector3(
            Mathf.Clamp(throwingArrow.transform.position.x + movePosition, arrowMinPosition, arrowMaxPosition),
                throwingArrow.position.y,
                throwingArrow.position.z
            );
        // Set ball position based on throwing direction position
        ball.position = throwingArrow.position + ballOffset;
    }
}
