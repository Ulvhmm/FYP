using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController character;
    public Transform cam;
    public Animator animator;
    public float CharacterMovSpeed = 2f;
    public float CharacterRotSpeed = 4f;

    Vector3 moveDirection;
    Vector3 lastPost;

    void Start()
    {

    }

    void Update()
    {
        //Velocity
        float velocity = (character.transform.position - lastPost / Time.deltaTime).magnitude;
        Debug.Log(velocity);

        lastPost = character.transform.position;

        float sideMove = 0;
        float forwardMove = 0;

        sideMove += Input.GetAxis("Horizontal");
        forwardMove += Input.GetAxis("Vertical");

        Vector3 sideMoveScreen = Quaternion.Euler(0f, cam.eulerAngles.y, 0f) * Vector3.right;
        Vector3 forwardMoveScreen = Quaternion.Euler(0f, cam.eulerAngles.y, 0f) * Vector3.forward;

        moveDirection = sideMoveScreen * sideMove + forwardMoveScreen * forwardMove;
        character.Move(moveDirection * CharacterMovSpeed * Time.deltaTime);

        Quaternion characterLookDirection = Quaternion.LookRotation(moveDirection);

        if(moveDirection.magnitude > 0f)
        character.transform.rotation = Quaternion.Slerp(character.transform.rotation, characterLookDirection, CharacterRotSpeed * Time.deltaTime);
    }
}