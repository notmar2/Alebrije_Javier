using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPlayer : BasePlayer
{
   public override void ProcessCollision()
   {
        Debug.Log("Procesando Colision desde Pong"); 
   }

   public override void MoveDirection(Direction direction)
    {
        Debug.Log("Procesando Movimiento desde Pong");
    }
}
