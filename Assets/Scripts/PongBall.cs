using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    public PongUI ui;
    public float speed = 300;
    Vector3 startingPosition;
    public RectTransform rectTransform;
    public Rigidbody2D rb;

    void Start()
    {
        startingPosition = rectTransform.localPosition;
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch()
    {
        float x = 0;
        float y = 0;

        if(Random.Range(0, 100) <= 50)
            x = 1;
        else
            x = -1;
        if(Random.Range(0, 100) <= 50)
            y = 1;
        else
            y = -1;
        rb.velocity = new Vector2(x,y) * speed;
    }

    public void ResetPosition()
    {
        rb.velocity = new Vector2(0, 0);
        rectTransform.localPosition = startingPosition;
        Invoke("Launch", 2);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "PongPlayer")
        {
            BounceFromPlayer(1);
        }
        else if (other.gameObject.name == "Enemy")
        {
            BounceFromPlayer(-1);
        }
        else if (other.gameObject.name == "BordeDerecha")
        {
            ui.AddPointsToLeft();
            ResetPosition();
        }
        else if (other.gameObject.name == "BordeIzquierda")
        {
            ui.AddPointsToRight();
            ResetPosition();
        }
        else if (other.gameObject.name == "BordeSuperior")
        {
            BounceFromWall(-1);
        }
        else if (other.gameObject.name == "BordeInferior")
        {
            BounceFromPlayer(1);
        }
    }

    public void BounceFromPlayer(float _direction){
        float verticalDirection = 0;
        if (rb.velocity.y < 0) verticalDirection = -1;
            else verticalDirection = 1;

            Vector2 direction = new Vector2(_direction, verticalDirection);

            rb.velocity = direction * speed;
    }

    public void BounceFromWall(float _direction){
        float horizontalDirection = 0;
        if (rb.velocity.x < 0) horizontalDirection = -1;
        else horizontalDirection = 1;

        Vector2 direction = new Vector2(horizontalDirection, _direction);

        rb.velocity = direction * speed;
    }
}
