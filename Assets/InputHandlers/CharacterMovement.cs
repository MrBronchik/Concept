using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    CharacterController characterControllerComponent;

    bool isGrounded;

    [Header("Settings")]
    [SerializeField] float moveForce;
    [SerializeField] float jumpForce;

    Vector2 vecMove = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        characterControllerComponent = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(vecMove);
        //characterControllerComponent.Move(vecMove * moveForce);

        gameObject.transform.position += new Vector3(
            vecMove.x * moveForce * Time.deltaTime,
            0.0f,
            vecMove.y * moveForce * Time.deltaTime
            );
    }

    public void OnMove(InputValue input)
    {
        vecMove = input.Get<Vector2>();
    }
}
