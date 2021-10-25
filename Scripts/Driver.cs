using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour

{
    [SerializeField] float steerSpeed = 100;
    [SerializeField] float moveSpeed = 6;
    [SerializeField] float lowDrive = 5;
    [SerializeField] float highDrive = 10;

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SpeedUps")
        {
            moveSpeed = highDrive;
        }
        if (other.tag == "SlowDowns")
        {
            moveSpeed = lowDrive;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float throttle = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, throttle, 0);
        if (throttle < 0)
        {
            transform.Rotate(0, 0, steerAmount);
        }
        else
        {
            transform.Rotate(0, 0, -steerAmount);
        }
    }
}
