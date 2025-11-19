using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

        MoveAction.Enable();
    }


    // Update is called once per frame
    void Update()

    {
        Vector2 move = MoveAction.ReadValue<Vector2>();

        Vector2 position = (Vector2)transform.position + move * 10.0f * Time.deltaTime;

        transform.position = position;
    }
}
