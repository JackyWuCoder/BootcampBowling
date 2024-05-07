using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerMovementSpeed = 1.0f;
    public float arrowMinPosition = -0.25f;
    public float arrowMaxPosition = 0.25f;
    public Transform throwingArrow;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
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
        throwingArrow.transform.position += throwingArrow.transform.right * horizontalInput * playerMovementSpeed * Time.deltaTime;
    }

    private void MoveArrowWithConstraints()
    {
        // Moving with constraints
        float movePosition = Input.GetAxis("Horizontal") * playerMovementSpeed * Time.deltaTime;
        throwingArrow.transform.position = new Vector3(
            Mathf.Clamp(throwingArrow.transform.position.x + movePosition, arrowMinPosition, arrowMaxPosition),
                throwingArrow.transform.position.y,
                throwingArrow.transform.position.z
            );
    }
}
