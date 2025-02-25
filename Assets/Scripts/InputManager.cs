using System;
using UnityEngine;
using UnityEngine.Events;


public class InputManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();

    // Update is called once per frame
    void Update()
    {
        Vector2 input = Vector2.zero;

        if(Input.GetKeyDown(KeyCode.W))
        {
            input += Vector2.up;
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            input += Vector2.down;
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            input += Vector2.left;
        }

        if(Input.GetKeyDown(KeyCode.D)){
            input += Vector2.right;
        }

        OnMove?.Invoke(input);
    }
}
