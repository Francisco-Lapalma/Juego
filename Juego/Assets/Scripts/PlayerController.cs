using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController ccPlayer;
    [SerializeField] private float speedPlayer = 3f;
    [SerializeField] private float playerGravity = 5f;
    private bool isAbleToGrab = false;

    private void Awake()
    {
        ccPlayer = GetComponent<CharacterController>();
    }

    void Start()
    {

    }


    void Update()
    {
        PlayerGravity();
        GetImputMovementPlayer();
    }

    private void MovementPlayer(Vector3 direction)
    {
        ccPlayer.Move(direction * speedPlayer * Time.deltaTime);
    }

    private void GetImputMovementPlayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MovementPlayer(Vector3.forward.normalized);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            MovementPlayer(Vector3.back.normalized);
        }

        if (Input.GetKey(KeyCode.A))
        {
            MovementPlayer(Vector3.left.normalized);
        }

        if (Input.GetKey(KeyCode.D))
        {
            MovementPlayer(Vector3.right.normalized);
        }
    }

    private void PlayerGravity()
    {
        ccPlayer.Move(Vector3.down * playerGravity * Time.deltaTime);
    }

    private void GrabItem()
    {
        if (isAbleToGrab == true)
        {
            
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.CompareTag("AreaGrab"))
        {
            isAbleToGrab = true;
            Debug.Log("Se puede agarrar");
        }
    }

}
