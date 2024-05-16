using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isFallen;

    private Vector3 startPosition;
    private Quaternion startRotation;

    private Rigidbody pinRb;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;

        pinRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if pin has fallen
        Debug.Log("The Angle btw start rotation and current rotation is " + Quaternion.Angle(startRotation,transform.localRotation));
    }
}
