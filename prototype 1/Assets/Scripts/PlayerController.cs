using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 7f;
    private float turnSpeed = 12f;
    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        
        transform.Translate(Vector3.forward * Time.deltaTime*speed*verticalInput);
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * (turnSpeed*7) * horizontalInput);
    }
}