using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCamera : MonoBehaviour
{
    public Transform target;
    public float MouseX = 0f, MouseY = 0f;
    public Vector3 offset;
    void Start()
    {
        
        Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
        MouseX += Input.GetAxis("Mouse X")* 2;
        while (MouseY >= -90 && MouseY <= 90) {
            MouseY -= Input.GetAxis("Mouse Y") * 2;
            break;
        }
        transform.eulerAngles = new Vector3(MouseY, MouseX, 0);


    }
}

