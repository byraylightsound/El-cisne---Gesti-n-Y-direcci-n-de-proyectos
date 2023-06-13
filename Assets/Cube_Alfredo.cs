using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Alfredo : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 50f;
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float vertcalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, vertcalInput);
        movementDirection.Normalize();

        transform.position = transform.position + movementDirection * speed * Time.deltaTime;

        if(movementDirection != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(movementDirection),rotationSpeed * Time.deltaTime);
    }
}
