using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class CameraMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //WASD move left right forward back 
        //space ctrl move up down 
        float horizontal = Input.GetAxis("Horizontal");
        float vertial = Input.GetAxis("Vertical");
        float up = Input.GetAxis("Jump");

        Vector3 move = new Vector3(horizontal, up, vertial).normalized;
        transform.Translate(move * movementSpeed * Time.deltaTime, Space.Self);

        //Mouse Movement 
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.eulerAngles += new Vector3(-mouseY * sensitivity, mouseX * sensitivity, 0);


        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Break();
        }

    }
}
