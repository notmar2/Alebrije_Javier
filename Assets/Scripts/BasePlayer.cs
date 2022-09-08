using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { Up, Down, Left, Right }

public class BasePlayer : MonoBehaviour
{
    public bool horizontalMovement, verticalMovement, detectCollisions, canShoot;
    public float maxSpeed, currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && verticalMovement)
        {
            MoveDirection(Direction.Up);
        }
        if(Input.GetKeyDown(KeyCode.A) && horizontalMovement)
        {
            MoveDirection(Direction.Left);
        }
        if(Input.GetKeyDown(KeyCode.S) && verticalMovement)
        {
            MoveDirection(Direction.Down);
        }
        if(Input.GetKeyDown(KeyCode.D) && horizontalMovement)
        {
            MoveDirection(Direction.Up);
        }
        if(Input.GetKeyDown(KeyCode.Space) && canShoot)
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
