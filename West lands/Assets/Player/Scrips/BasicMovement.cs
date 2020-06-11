using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    public float speed;
    
    public void Move(float speedX,float speedY, float whate, Rigidbody2D rb)
    {
        rb.velocity.Set(speedX/whate, speedY/whate);
    }

    public void MoveToPos(Transform vec1, Transform vec2)
    {
        vec1.position = Vector2.Lerp(vec1.position, vec2.position, 0.5f);
    }
}
