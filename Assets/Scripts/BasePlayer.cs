using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { Up, Down, Left, Right }

public class BasePlayer : MonoBehaviour
{
    [Header("Controles")]
    public KeyCode movementUp;
    public KeyCode movementDown, movementLeft, movementRight, shoot;

    [Header("Configuracion")]
    public bool horizontalMovement;
    public bool verticalMovement, detectCollisions, canShoot;

    [Header("Variables")]
    public float maxSpeed;
    public float currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(movementUp) && verticalMovement)
        {
            MoveDirection(Direction.Up);
        }
        if(Input.GetKey(movementLeft) && horizontalMovement)
        {
            MoveDirection(Direction.Left);
        }
        if(Input.GetKey(movementDown) && verticalMovement)
        {
            MoveDirection(Direction.Down);
        }
        if(Input.GetKey(movementRight) && horizontalMovement)
        {
            MoveDirection(Direction.Right);
        }
        if(Input.GetKeyDown(shoot) && canShoot)
        {
            Shoot();
        }
    }

    public virtual void MoveDirection(Direction direction)
    {
        Debug.Log("Procesando Movimiento");
    }

    public virtual void Shoot()
    {
        Debug.Log("Shooting");
    }

    void OnTriggerEnter(Collider other)
    {
        if (detectCollisions)
            ProcessCollision();
    }

    public virtual void ProcessCollision()
    {
        Debug.Log("Procesando Colision");
    }
}
