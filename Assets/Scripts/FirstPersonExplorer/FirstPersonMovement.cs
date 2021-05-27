using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 direction;
    public float speed;

    public Rigidbody rb; //player

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // All physics calculation happen in FixedUpdate
    void FixedUpdate()
    {
        //transform.Translate(direction * speed * Time.deltaTime);
        Vector3 localDirection = transform.TransformDirection(direction);
        rb.MovePosition(rb.position + (localDirection * speed * Time.deltaTime));
    }

    public void OnPlayerMove(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();

        direction.x = inputVector.x;
        direction.z = inputVector.y;

        direction.y = 0f;
    }
}
