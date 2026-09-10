using UnityEngine;

public class BallMovement : MonoBehaviour
{
   
    public float speed = 5f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(speed, speed);
    }
}
