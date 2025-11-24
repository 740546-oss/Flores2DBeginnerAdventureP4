using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Variables related to player character movement
    public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;

    public InputAction Move;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()

    {
        Vector2 move = MoveAction.ReadValue<Vector2>();

        Vector2 position = (Vector2)transform.position + move * 10.0f * Time.deltaTime;

        transform.position = position;

        move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);

        void FixedUpdate()
        {
            Vector2 position = (Vector2)rigidbody2d.position + move * 3.0f * Time.deltaTime;
            rigidbody2d.MovePosition(position);
        }
    }
}
