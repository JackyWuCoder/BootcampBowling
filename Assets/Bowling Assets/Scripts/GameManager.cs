using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Pin[] pins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetNextThrow()
    {
        CalculateFallenPins();
        // Get the ball to the start position for throwing
        playerController.StartThrow();
    }

    public void CalculateFallenPins()
    {
        int count = 0;
        foreach (Pin pin in pins)
        {
            if (pin.isFallen)
            {
                count++;
            }
        }
        Debug.Log("Total Fallen Pins " + count);
    }
}
